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

        public AccountController(IUserService userService , IMapper mapper, IOtpService otpService)
        {
            _userService = userService;
            _mapper = mapper;
            _otpService = otpService;
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
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("اطلاعات وارد شده نامعتبر است.");
            }

            try
            {
                var result = await _userService.Login(loginRequest.UserNameOrEmailORPhoneNumber, loginRequest.Password);
                if (!result.IsValid)
                {
                    return Unauthorized(new { result.StatusMessage });
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = "خطایی در فرآیند ورود رخ داده است.", details = ex.Message });
            }
        }

       

        [HttpPost("GenerateOtp")]
        public async Task<IActionResult> GenerateOtp([FromBody] GenerateOtpRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("اطلاعات وارد شده نامعتبر است.");
            }

            var otpCode = await _otpService.GenerateOtp(request.UserId, request.Email, request.PhoneNumber);

            return Ok(new { OtpCode = otpCode, Message = "رمز یکبار مصرف تولید شد." });
        }

        [HttpPost("ValidateOtp")]
        public async Task<IActionResult> ValidateOtp([FromBody] ValidateOtpRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("اطلاعات وارد شده نامعتبر است.");
            }

            var isValid = await _otpService.ValidateOtp(request.OtpCode);

            if (!isValid)
            {
                return Unauthorized("رمز یکبار مصرف نامعتبر یا منقضی شده است.");
            }

            return Ok("رمز یکبار مصرف معتبر است.");
        }

    }
}
