using ApiEndPoint.ViewModel;
using Mahface.Services.AppServices.Service;
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
        private readonly ISeasonService _seasonService;
        private readonly IViewService _viewService;
        private readonly ICommentService _commentService;
        private readonly IStudentCourseService _studentCourseService;
        public HomeController(IUserService Userservice , IOtpService otpService , IEmailService emailService ,ISeasonService seasonService , IViewService viewService,ICommentService commentService ,IStudentCourseService studentCourseService)
        {
            _UserService  = Userservice;            
            _otpService = otpService;
            _emailService = emailService;
           _seasonService = seasonService;
            _viewService =viewService;
            _commentService = commentService;
            _studentCourseService=studentCourseService;
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

         
        [HttpGet("SeedSeasonsData")]
        public async Task<ActionResult<AddStatusVm>> SeedSeasonsData(string adminEmail)
        {
            if (adminEmail=="razaviash21@gmail.com")
            {
                var result = await _seasonService.SeedData();
                return result;

            }

            AddStatusVm addStatusVm = new AddStatusVm();
            addStatusVm.IsValid=false;
            addStatusVm.StatusMessage="Email is not correct";
            return addStatusVm;
        }



        [HttpGet("SeedViewData")]
        public async Task<ActionResult<AddStatusVm>> SeedViewData(string adminEmail)
        {
            if (adminEmail=="razaviash21@gmail.com")
            {
                var result = await _viewService.SeedData();
                return result;

            }

            AddStatusVm addStatusVm = new AddStatusVm();
            addStatusVm.IsValid=false;
            addStatusVm.StatusMessage="Email is not correct";
            return addStatusVm;
        }

        [HttpGet("seed-comments")]
        public async Task<ActionResult<AddStatusVm>> SeedComments(string adminEmail)
        {
            try
            {

                if (adminEmail=="razaviash21@gmail.com")
                {
                    var result = await _commentService.SeedComments();
                    return result;

                }
                AddStatusVm addStatusVm = new AddStatusVm();
                addStatusVm.IsValid=false;
                addStatusVm.StatusMessage="Email is not correct";
                return addStatusVm;
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "خطایی در تولید نظرات رخ داده است.", Error = ex.Message });
            }
        }


        [HttpGet("Seed-StudentCourse")]
        public async Task<ActionResult<AddStatusVm>> SeedStudentCourse(string adminEmail)
        {
            try
            {
                if (adminEmail=="razaviash21@gmail.com")
                {
                   
                var result = await _studentCourseService.SeedData();

                    return result;
                   

                }
                AddStatusVm addStatusVm = new AddStatusVm();
                addStatusVm.IsValid=false;
                addStatusVm.StatusMessage="Email is not correct";
                return addStatusVm;

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "خطایی در تولید  رخ داده است.", Error = ex.Message });
            }
        }

        [HttpPost("SendPrivateEmail")]
        public async Task<ActionResult> SendPrivateEmail(string email, string message)
        {


            UpdateStatus result = new();
            try
            {

                result.IsValid = await _emailService.SendEmailAsync(email, "ایمیل ", message);
                result.StatusMessage=result.IsValid ? "با موفقیت ارسال شد" : "خطا در سرویس ارسال پیام ";
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.IsValid=false;
                result.StatusMessage="با خطا مواجه شد ";
                return BadRequest(result);
            }

        }




    }

}
