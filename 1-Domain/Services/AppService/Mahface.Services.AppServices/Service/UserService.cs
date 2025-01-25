using AutoMapper;
using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core1.Enums;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Domain.Core1.Interface.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mahface.Services.AppServices.Service
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IImageService _imageService;
        private readonly IEmailService _emailService;
        private readonly IOtpService _otpService;
        public UserService(UserManager<User> userManager, IMapper mapper, IUserRepository userRepository, IImageService imageService, IEmailService emailService, IOtpService otpService)

        {
            _userManager = userManager;
            _mapper = mapper;
            _userRepository = userRepository;
            _imageService=imageService;
            _emailService=emailService;
            _otpService=otpService;
        }

        public async Task<string> AddUser(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            user.PasswordHash=null;
            user.SecurityStamp=null;
            user.BirthDate=DateTime.Now;
            user.Id=new Guid();
            var password = "Admin123";
            try
            {
                var result = await _userManager.CreateAsync(user, password);

                if (result.Succeeded)
                {
                    return "User added successfully";
                }
                else
                {
                    var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                    throw new Exception($"User creation failed: {errors}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while adding User", ex);
            }
        }

        public async Task<UpdateStatus> DeleteUser(Guid id)
        {
            UpdateStatus updateStatus = new UpdateStatus();
            try
            {
                var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
                if (user == null)
                {
                     
                   updateStatus.StatusMessage=  "کاربر  یافت نشد";
                    updateStatus.IsValid= false;
                }
                //user.IsDeleted=true;
                ////await _userManager.UpdateAsync(user);
                //var result = await _userRepository.UpdateUserAsync(user);
               var result =   _userRepository.DeleteUserAsync(id);
                updateStatus.IsValid = true;
                updateStatus.StatusMessage="";
                return updateStatus ;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while adding User", ex);
            }
        }

        public async Task<IEnumerable<UserDto>> GetAllUsers()
        {
            var User = await _userManager.Users.ToListAsync();
            var UserDto = _mapper.Map<List<UserDto>>(User);
            return UserDto;
        }


        public async Task<UserDto> GetUserById(Guid id)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (user == null)
            {
                return null;
            }

            // Map User entity to UserDto using AutoMapper
            var userDto = _mapper.Map<UserDto>(user);
            return userDto;
        }



        public async Task<AddStatusVm> Register(AddUser addUser)
        {
            AddStatusVm vm = new AddStatusVm();
            try
            {
                var usersQuery = await _userRepository.GetallUsers();
                var existEmail = usersQuery.Any(user => user.Email == addUser.Email);
                
                if (existEmail)
                {
                    vm.IsValid=false;
                    vm.StatusMessage= "ایمیل وارد شده قبلاً ثبت شده است.";
                    return vm;
                }

                var existUsername = usersQuery.Any(u => u.UserName == addUser.UserName);
                if (existUsername)
                {
                    vm.IsValid=false;
                    vm.StatusMessage= "نام کاربری وارد شده قبلاً ثبت شده است.";
                    return vm;
                }

                User user = new User
                {
                    UserName = addUser.UserName,
                    Email = addUser.Email,
                    EmailConfirmed = false,
                    IsActived = true,
                    IsDeleted=false,
                    BirthDate=addUser.BirthDate,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    PhoneNumberConfirmed = false,
                    PhoneNumber=addUser.PhoneNumber,
                    LastName=addUser.LastName,
                    Firstname=addUser.Firstname,
                    NationalCode = addUser.NationalCode,
                    IsStudent=true,
                    IsTeacher=false,
                    IsSystemAccount=false,
                    IsSystemAdmin=false,
                    GenderType=addUser.GenderEnum
                };

                var result = await _userRepository.Register(user, addUser.Password);
                if (user.Email!=null && user.Email.Contains("@"))
                {

                    // ایجاد کد تایید 4 رقمی
                    var otpCode = new Random().Next(1000, 9999).ToString();
                    var otp = await _otpService.GenerateOtp(result.AddedId.Value, user.Email);
                    var emailToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var baseUrl = "https://mahface-allameh.ir/api/Account/CheckOtpWithToken";
                    var userId = result.AddedId.Value.ToString(); 
                    var confirmationLink = $"{baseUrl}?userId={userId}&emailToken={Uri.EscapeDataString(emailToken)}";

                    // ساخت پیام ایمیل
                    var emailMessage = $@"
                                            <p>ما خوشحالیم که شما را در جمع خود داریم. برای تکمیل ثبت‌نام یا تایید درخواست خود، لطفاً از کد تایید زیر استفاده کنید:</p>
                                            <h3>کد تایید: {otpCode}</h3>
                                            <p>لطفاً این کد را در سایت وارد کنید تا مراحل را ادامه دهید.</p>
                                            <p>یا روی لینک زیر کلیک کنید:</p>
                                            <a href=""{confirmationLink}"">تایید ایمیل</a>
                                            <p>اگر شما درخواست این ایمیل را نداده‌اید، لطفاً این پیام را نادیده بگیرید.</p>
                                            <p>با احترام،</p>
                                            <p>تیم MahfaceAllameh</p>";
                                            

                    var emailResult = await _emailService.SendEmailAsync(user.Email, "Register", emailMessage);
                }

                return result;

            }
            catch (Exception ex)
            {
                // مدیریت خطا (مانند لاگ کردن)
                throw new AppException("خطایی در فرآیند ثبت‌نام رخ داده است.", ex);
            }
        }

        public async Task<UpdateStatus> EditProfile(EditUserVm editUserVm)
        {
            UpdateStatus updateStatus = new UpdateStatus();
            try
            {
                var model = await _userRepository.GetUserByIdAsync(editUserVm.Id);
                if (model == null)
                {
                    updateStatus.IsValid = false;
                    updateStatus.StatusMessage = ".کاربری با این ایدی پیدا نشد";
                    return updateStatus; // Early return to avoid further processing
                }
                _mapper.Map(editUserVm, model);

                if (editUserVm.Base64Profile != null)
                {
                    ImageDto imageDto = new ImageDto();
                    imageDto.Base64File = editUserVm.Base64Profile;
                    imageDto.Url=editUserVm.Firstname+"_"+editUserVm.LastName+"Profile"+DateTime.Now.ToString();
                    var imageResult = await _imageService.AddImage(imageDto);
                    model.ProfileImageId=imageResult.AddedId;
                }

                var result = await _userRepository.UpdateUserAsync(model);

                return result;
            }
            catch (Exception ex)
            {
                throw new AppException("خطایی در فرآیند ویرایش رخ داده است.", ex);
            }
        }

        public Task<UpdateStatus> UpdateUserByAdmin(EditUserVm editUserVm)
        {
            throw new NotImplementedException();
        }

        public async Task<LoginResponseVm> Login(string email, string password)
        {
            LoginResponseVm loginResponse = new LoginResponseVm();

            try
            {
                // Find user by email
                var user = await _userManager.Users.Include(u => u.Image).FirstOrDefaultAsync(u => u.Email == email || u.UserName==email || u.PhoneNumber==email);
                if (user == null)
                {
                    loginResponse.IsValid = false;
                    loginResponse.StatusMessage = "کاربری با این مشخصات یافت نشد.";
                    return loginResponse;
                }

                // Verify password
                var isPasswordValid = await _userManager.CheckPasswordAsync(user, password);
                if (!isPasswordValid)
                {
                    loginResponse.IsValid = false;
                    loginResponse.StatusMessage = "رمز عبور اشتباه است.";
                    return loginResponse;
                }
                if (!user.EmailConfirmed)
                {
                    loginResponse.IsValid = false;
                    loginResponse.StatusMessage = "ایمیل کاربر تایید نشده است";
                    
                    
                }
                // Map user details to LoginResponseVm
                loginResponse.IsValid = true;
                loginResponse.UserId = user.Id;
                loginResponse.UserName=user.UserName;
                loginResponse.IsTeacher = user.IsTeacher;
                loginResponse.Firstname = user.Firstname;
                loginResponse.LastName = user.LastName;
                loginResponse.Email = user.Email;
                loginResponse.StatusMessage = "ورود موفقیت‌آمیز بود.";
                loginResponse.IsAdmin= (user.IsSystemAccount || user.IsSystemAdmin) ? true : false;
                loginResponse.EmailConFirm= user.EmailConfirmed;
                var gender = (GenderEnum)user.GenderType;
                loginResponse.GenderTypeString=gender.GetDisplayName();
                loginResponse.PhoneNumber=user.PhoneNumber;
                loginResponse.NationalCode=user.NationalCode;


                // Retrieve profile image in Base64 format
                if (user.ProfileImageId != null)
                {
                    var image = await _imageService.GetImageById(user.ProfileImageId.Value);
                    loginResponse.ProfileImageBase64 = image.Base64File;
                }

                return loginResponse;
            }
            catch (Exception ex)
            {
                // Handle exceptions and provide an error message
                throw new AppException("خطایی در فرآیند ورود رخ داده است.", ex);
            }
        }

        public async Task<UserDto> GetUserByTeacherId(Guid teacherId)
        {
            var user = await _userRepository.GetUserByTeacherIdAsync(teacherId);
            if (user == null)
            {
                return null;
            }

            // Map User entity to UserDto using AutoMapper
            var userDto = _mapper.Map<UserDto>(user);
            return userDto;
        }

        public Task<UpdateStatus> EmailConfirm(Guid userId, string emailToken)
        {
            if (emailToken == null)
            {

                return _userRepository.EmailConfirm(userId);
            }
            else
            {
                return _userRepository.EmailConfirmWithToken(userId, emailToken);
            }
        }
    }
}
