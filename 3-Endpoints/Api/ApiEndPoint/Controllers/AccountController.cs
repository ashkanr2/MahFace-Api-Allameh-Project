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

        [HttpPost("Register")]
        public async Task<AddStatusVm> Register(AddUser addUser)
        {
            addUser.Password="12345678";
            var result = await _userService.Register(addUser);
            return result;
        }


        [HttpPost("EditProfile")]
        public async Task<UpdateStatus> EditProfile(EditUserVm editUserVm)
        {

            UpdateStatus updateStatus = new UpdateStatus();
            var result = await _userService.EditProfile(editUserVm);

            return result;
        }
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
        /// مقدار 1234 پیشفرض کد طلایی ست شده
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="otp"></param>
        /// <returns></returns>
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

        [HttpPost("CheckOtpWithToken")]
        public async Task<UpdateStatus> CheckOtpWithToken(Guid userId, string emailToken)
        {


            var result = await _userService.EmailConfirm(userId, emailToken);
            return result;

        }

        //[HttpGet("Email")]
        //public async Task<bool> Email()
        //{


        //        var to = "razaviash21@gmail.com";
        //    var emailMessage = $"\n\nسلام، به سایت MahfaceAllameh خوش آمدید! " +
        //            $"\n\nما خوشحالیم که شما را در جمع خود داریم. برای تکمیل ثبت‌نام یا تایید درخواست خود، لطفاً از کد تایید زیر استفاده کنید:" +
        //            $"\n\nکد تایید: 1234" +
        //            $"\n\nلطفاً این کد را در سایت وارد کنید تا مراحل را ادامه دهید." +
        //            $"\n\nاگر شما درخواست این ایمیل را نداده‌اید، لطفاً این پیام را نادیده بگیرید." +
        //            $"\n\nبا احترام،" +
        //            $"\n\nتیم MahfaceAllameh";

        //    var x = await _emailService.SendEmailAsync(to, "Login", emailMessage);

        //    return x; 
        //}


    }
}
