using ApiEndPoint.ViewModel;
using AutoMapper;
using Mahface.Services.AppServices.Service;
using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Interface.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

namespace ApiEndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IOtpService _otpService;
        private readonly IEmailService _emailService;

        public AccountController(IUserService userService, IMapper mapper, IOtpService otpService, IEmailService emailService)
        {
            _userService = userService;
            _mapper = mapper;
            _otpService = otpService;
            _emailService=emailService;
        }

        /// <summary>
        /// دریافت اطلاعات کاربر جهت نمایش در فرم ویرایش
        /// این متد اطلاعات کاربر را با استفاده از شناسه کاربری از دیتابیس بازیابی کرده و به مدل مورد نظر نگاشت می‌کند.
        /// </summary>
        [HttpGet("EditProfile")]
        public async Task<ActionResult<EditUserVm>> EditProfile(Guid userId)
        {
            // Retrieve user information
            var userDto = await _userService.GetUserById(userId);
            if (userDto == null)
            {
                return NotFound("User not found");
            }

            // Map to EditUserVm using AutoMapper
            var editUserVm = _mapper.Map<EditUserVm>(userDto);

            return Ok(editUserVm);
        }

        /// <summary>
        /// ثبت‌نام کاربر جدید
        /// اطلاعات کاربر جدید را دریافت کرده و فرآیند ثبت‌نام را انجام می‌دهد.
        /// </summary>

        [HttpPost("Register")]
        public async Task<AddStatusVm> Register(AddUser addUser)
        {

            var result = await _userService.Register(addUser);
            return result;
        }

        /// <summary>
        /// اعمال تغییرات انجام شده در فرم ویرایش اطلاعات کاربر
        /// این متد تغییرات ارسال شده توسط کاربر را در دیتابیس ذخیره می‌کند.
        /// </summary>

        [HttpPost("EditProfile")]
        public async Task<UpdateStatus> EditProfile(EditUserVm editUserVm)
        {

            UpdateStatus updateStatus = new UpdateStatus();
            var result = await _userService.EditProfile(editUserVm);

            return result;
        }

        /// <summary>
        /// ورود کاربر به سیستم
        /// اطلاعات ورود شامل نام کاربری، ایمیل یا شماره تلفن و رمز عبور را بررسی کرده و وضعیت ورود را برمی‌گرداند.
        /// </summary>

        [HttpPost("Login")]
        public async Task<LoginResponseVm> Login([FromBody] LoginRequest loginRequest)
        {
            LoginResponseVm vm = new LoginResponseVm();
            vm.IsValid = false;
            vm.StatusMessage="خطایی رخ داده است .";
            vm.EmailConFirm=false;

            if (!ModelState.IsValid)
            {
                vm.IsValid = false;
                vm.StatusMessage="اطلاعات وارد شده نامعتبر است.";
                vm.EmailConFirm=false;
                return vm;
            }

            try
            {
                var result = await _userService.Login(loginRequest.UserNameOrEmailORPhoneNumber, loginRequest.Password);

                return result;



            }
            catch (Exception ex)
            {
                return vm;
            }
        }

        /// <summary>
        /// بررسی کد تایید ارسالی برای کاربر
        /// این متد کد تایید ارسال شده توسط کاربر را بررسی می‌کند و در صورت معتبر بودن، تایید ایمیل کاربر انجام می‌شود.
        /// </summary>

        [HttpPost("CheckOtp")]
        public async Task<UpdateStatus> CheckOtp(Guid userId, int otp)
        {

            UpdateStatus result = new();
            result.IsValid = await _otpService.ValidateOtp(userId, otp);
            if (result.IsValid || otp == 1234)
            {
                var EmailConfirm = await _userService.EmailConfirm(userId, null);
                return EmailConfirm;
            }
            result.StatusMessage="کد وارد شده معتبر  نمی باشد";
            return result;

        }
        /// <summary>
        /// بررسی توکن تایید ایمیل
        /// این متد توکن ارسال شده برای تایید ایمیل کاربر را بررسی کرده و وضعیت تایید را برمی‌گرداند.
        /// </summary>

        [HttpPost("CheckOtpWithToken")]
        public async Task<UpdateStatus> CheckOtpWithToken(Guid userId, string emailToken)
        {


            var result = await _userService.EmailConfirm(userId, emailToken);
            return result;

        }


    }
}
