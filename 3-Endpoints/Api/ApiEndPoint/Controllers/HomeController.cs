using ApiEndPoint.ViewModel;
using MAhface.Domain.Core.Entities.BasicInfo.Business;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Interface.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiEndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IUserService _UserService;
        private readonly IOtpService _otpService;
        private readonly IEmailService _emailService;
      
        public HomeController(IUserService Userservice , IOtpService otpService , IEmailService emailService)
        {
            _UserService  = Userservice;            
            _otpService = otpService;
            _emailService = emailService;
           
        }

        [HttpGet("GetUrls")]
        public IActionResult GetUrls()
        {
            var urls = new List<string>
            {
                "https://media1.maktabkhooneh.org/landpage/banners/4.webp?expire=1718025003&token=4d058c16b0ef25d08bcd2d5d96a2b6b5",
                "https://media1.maktabkhooneh.org/landpage/banners/2024/6/3e32e165-eddc-4a51-a486-41c501cb9aed.gif?expire=1718025003&token=371ab759da299434d237cdadc3b78f42",
                "https://media1.maktabkhooneh.org/landpage/banners/3.webp?expire=1718025003&token=183480f48bbc509d62e1c1f9a5030308",
                "https://media1.maktabkhooneh.org/landpage/banners/5.webp?expire=1718025003&token=65294cc7fbf42cba5595dc9d1f9b9f2a",
                "https://media1.maktabkhooneh.org/landpage/banners/2.webp?expire=1718025003&token=cb6638fb90062af851be99c7a95054bf"
            };

            return Ok(urls);
        }

        [HttpGet("GetUSerInfo")]
        public async Task<ActionResult<UserDto>> GetById(Guid Id)
        {
            var userDtos = await _UserService.GetUserById(Id);
            return Ok(userDtos);
           
        }


        [HttpGet("GetLastTenOTP")]
        public async Task<ActionResult<UserDto>> GetLastTenOTP()
        {
           
            var result = await _otpService.GetAllOTP();

            return Ok(result.OrderByDescending(x=>x.CreatedTime).Take(10).ToList());

        }


        [HttpPost("SendEmail")]
        public async Task<bool> SendEmail(string DeliverAddress , string text )
        {
          var x = await _emailService.SendEmailAsync(DeliverAddress, "Test Email", text);

            return x;
        }
    }

}
