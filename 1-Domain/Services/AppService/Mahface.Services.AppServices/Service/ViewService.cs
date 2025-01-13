using AutoMapper;
using MAhface.Domain.Core.Entities.BasicInfo.Business;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Domain.Core1.Interface.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahface.Services.AppServices.Service
{
    public class ViewService : IViewService
    {
        private readonly IViewRepository _viewRepository;
        private readonly ISectionService _sectionService;
        private readonly IMapper _mapper;

        public ViewService(ISectionService sectionService , IViewRepository viewRepository, IMapper mapper)
        {
            _viewRepository = viewRepository;
            _mapper = mapper;
            _sectionService = sectionService;
        }

        public async Task<ViewDTO> GetViewDetailsById(Guid id)
        {
            try
            {
                var view = await _viewRepository.GetById(id);

                if (view == null)
                {
                    throw new Exception("View not found.");
                }

                return _mapper.Map<ViewDTO>(view);
            }
            catch (Exception ex)
            {
                // Log the exception
                throw new Exception("An error occurred while retrieving the View details.", ex);
            }
        }

        public async Task<(bool hasViewed, TimeOnly? lastVideoTime)> HasUserViewedCourse(Guid userId, Guid SectionId)
        {
            try
            {
                var view = await _viewRepository.GetByUserAndSectionId(userId, SectionId);
                if (view != null)
                {
                    return (true, view.LastVideoTime);
                }
                return (false, null);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while checking if the user viewed the course.", ex);
            }
        }
        public async Task<AddStatusVm> AddViewAsync( Guid sectionId, Guid userId, TimeOnly lastVideoTime)
        {
            try
            {
               
                var existingView = await _viewRepository.GetByUserAndSectionId(userId, sectionId);

                if (existingView != null)
                {

                    existingView.LastVideoTime = lastVideoTime;
                    await _viewRepository.UpdateView(existingView);

                    return new AddStatusVm
                    {
                        IsValid = true,
                        StatusMessage = "View updated successfully."
                    };
                }

                var section = await _sectionService.GetSectionDetails(sectionId);    

                var newView = new View
                {
                    Id = Guid.NewGuid(),
                   CourseId= section.CourseId,
                    SectionId = sectionId,
                    UserId = userId,
                    LastVideoTime = lastVideoTime
                };

                await _viewRepository.AddView(newView);

                return new AddStatusVm
                {
                    IsValid = true,
                    StatusMessage = "View added successfully."
                };
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding or updating the View.", ex);
            }
        }


        public async Task<int> GetTotalViewsForCourse(Guid courseId)
        {
            try
            {
                return await _viewRepository.CountOfCourseView(courseId);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving the total views for the course.", ex);
            }
        }

        public async Task<int> GetTotalViewsForCourseByUser(Guid userId, Guid courseId)
        {
            try
            {
                var views = await _viewRepository.GetByUserAndSectionId(userId, courseId);
                return views != null ? 1 : 0; // Returns 1 if a view exists, 0 otherwise
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while counting course views for the user.", ex);
            }
        }

        public Task<int> CountOfCourseView(Guid courseId)
        {
          return  _viewRepository.CountOfCourseView(courseId);
        }
    }

}
