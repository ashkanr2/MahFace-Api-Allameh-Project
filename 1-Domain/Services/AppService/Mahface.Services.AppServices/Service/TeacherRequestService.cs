﻿using AutoMapper;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core1.Enums;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Domain.Core1.Interface.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahface.Services.AppServices.Service
{
    public class TeacherRequestService : ITeacherRequestService
    {
        private readonly ITeacherRequestRepository _teacherRequestRepository;
        private readonly ITeacherRepository _teacherRepository; // Assuming this exists
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public TeacherRequestService(ITeacherRequestRepository repository, ITeacherRepository teacherRepository, IMapper mapper, IUserService userService)
        {
            _teacherRequestRepository = repository;
            _teacherRepository = teacherRepository;
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<AddStatusVm> CreateTeacherRequest(Guid userId, string userDescription)
        {
            var user = await _userService.GetUserById(userId);
            if (user == null)
            {
                return new AddStatusVm
                {
                    IsValid = false,
                    StatusMessage = "کاربری با این آیدی یافت نشد ",
                    AddedId = userId
                };

            }
            if (user.IsTeacher) {
                return new AddStatusVm
                {
                    IsValid = false,
                    StatusMessage = "این کاربر استاد می باشد",
                    AddedId = userId
                };
            }
            var existRequest = await _teacherRequestRepository.GetRequestByUserId(userId);


            if (existRequest != null && !existRequest.IsDeleted)
            {
                var status = (TeacherRequestStatusEnum)existRequest.StatusCode;

                return new AddStatusVm
                {
                    IsValid = false,
                    StatusMessage = "شما قبلا درخواستی ثبت کرده اید و نتیجه آن " + status.GetDisplayName() + " می باشد",
                    AddedId = existRequest.Id
                };

            }

            var teacherRequest = new TeacherRequests
            {
                UserId = userId,
                UserDescription = userDescription,
                UserRequestDate = DateTime.Now,
                StatusCode = (int)TeacherRequestStatusEnum.Pending
            };
            await _teacherRequestRepository.AddTeacherRequest(teacherRequest);

            return new AddStatusVm
            {
                IsValid = true,
                StatusMessage = "با موفقیت انجام شد",
                AddedId=teacherRequest.Id
            };
        }

        public async Task<List<TeacherRequestVm>> GetAllRequests()
        {
            var requests = await _teacherRequestRepository.GetAllRequests();
            return _mapper.Map<List<TeacherRequestVm>>(requests);
        }

        public async Task<UpdateStatus> ApproveRequest(Guid requestId, Guid adminId)
        {
            var request = await _teacherRequestRepository.GetRequestById(requestId);
            if (request == null)
            {
                return new UpdateStatus { IsValid = false, StatusMessage = "چنین درخواستی پیدا نشد " };
            }
            request.StatusCode = (int)TeacherRequestStatusEnum.Approved;
            request.AdminResponseDate = DateTime.Now;
            await _teacherRequestRepository.UpdateRequest(request);
            var AddTEacherResult = await _teacherRepository.CreateTeacher(request.UserId);

            return new UpdateStatus { IsValid = AddTEacherResult.IsValid, StatusMessage =AddTEacherResult.StatusMessage };
        }

        public async Task<UpdateStatus> RejectRequest(Guid requestId, string adminDescription, Guid adminId)
        {
            var request = await _teacherRequestRepository.GetRequestById(requestId);
            if (request == null)
            {
                return new UpdateStatus { IsValid = false, StatusMessage ="چنین درخواستی پیدا نشد " };
            }

            request.StatusCode = (int)TeacherRequestStatusEnum.Rejected;
            request.AdminDescription = adminDescription;
            request.AdminResponseDate = DateTime.Now;

            await _teacherRequestRepository.UpdateRequest(request);

            return new UpdateStatus
            {
                IsValid = true,
                StatusMessage= "با موفقیت انجام شد"
            };
        }

        public async Task<UpdateStatus> ApproveMultipleRequests(List<Guid> requestIds, Guid adminId)
        {
            var status = new UpdateStatus { IsValid = true, StatusMessage = "تمام درخواست‌ها با موفقیت تایید شدند." };

            foreach (var requestId in requestIds)
            {
                var requestStatus = await ApproveRequest(requestId, adminId); // Using the existing single-request approval method

                if (!requestStatus.IsValid)
                {
                    status.IsValid = false;
                    status.StatusMessage = "یکی از درخواست‌ها تایید نشد: " + requestStatus.StatusMessage;
                    break; // Optionally break the loop if one fails
                }
            }

            return status;
        }

        public async Task<UpdateStatus> RejectMultipleRequests(List<Guid> requestIds, string adminDescription, Guid adminId)
        {
            var status = new UpdateStatus { IsValid = true, StatusMessage = "تمام درخواست‌ها با موفقیت رد شدند." };

            foreach (var requestId in requestIds)
            {
                var rejectStatus = await RejectRequest(requestId, adminDescription, adminId); // Using the existing single-request rejection method

                if (!rejectStatus.IsValid)
                {
                    status.IsValid = false;
                    status.StatusMessage = "یکی از درخواست‌ها رد نشد: " + rejectStatus.StatusMessage;
                    break; // Optionally break the loop if one fails
                }
            }

            return status;
        }

        public async Task<RequestStatus> GetUserTeacherRequestStatus(Guid userId)
        {
            RequestStatus requestStatus = new RequestStatus();
            
            try
            {
                // Fetch the teacher request by userId
                var request = await _teacherRequestRepository.GetRequestByUserId(userId);

                // If no request exists
                if (request == null)
                {
                    requestStatus.StatusDescripton = "برای این کاربر درخواستی در سیستم وجود ندارد";
                    requestStatus.Status = 0;
                    requestStatus.HasActiveRequest = false;
                    return requestStatus;
                }
                requestStatus.Id = request.Id;
                requestStatus.UserDescription=request.UserDescription;
                requestStatus.UserRequestDate=request.UserRequestDate;
                requestStatus.AdminResponseDate=request.AdminResponseDate;
                requestStatus.AdminDescription=request.AdminDescription;
                // If the request is pending (Admin has not responded yet)
                if (request.AdminResponseDate == null)
                {
                    requestStatus.StatusDescripton = "درخواست شما در حال بررسی است";
                    requestStatus.Status = (int)TeacherRequestStatusEnum.Pending;
                    requestStatus.HasActiveRequest = true;
                    return requestStatus;
                }

                // If the request has been approved
                if (request.StatusCode == (int)TeacherRequestStatusEnum.Approved)
                {
                    requestStatus.StatusDescripton = "درخواست شما تایید شده است";
                    requestStatus.Status = (int)TeacherRequestStatusEnum.Approved;
                    requestStatus.HasActiveRequest = false; // No active request since it's approved
                    return requestStatus;
                }

                // If the request has been rejected
                if (request.StatusCode == (int)TeacherRequestStatusEnum.Rejected)
                {
                    requestStatus.StatusDescripton = "درخواست شما رد شده است";
                    requestStatus.Status = (int)TeacherRequestStatusEnum.Rejected;
                    requestStatus.HasActiveRequest = false; // No active request since it's rejected
                    return requestStatus;
                }

                // If none of the above conditions are met, return a default status
                requestStatus.StatusDescripton = "وضعیت درخواست مشخص نیست";
                requestStatus.Status = -1; // Undefined status
                requestStatus.HasActiveRequest = false;
                return requestStatus;
            }
            catch (Exception ex)
            {
                // Handle exception and return a failure status
                requestStatus.StatusDescripton = "خطایی در پردازش درخواست رخ داده است";
                requestStatus.Status = -1; // Indicating an error
                requestStatus.HasActiveRequest = false;
                return requestStatus;
            }
        }

    }
}
