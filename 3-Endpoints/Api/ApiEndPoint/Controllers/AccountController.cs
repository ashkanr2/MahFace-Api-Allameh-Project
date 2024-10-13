using ApiEndPoint.ViewModel;
using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Interface.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ApiEndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Register")]
        public async Task<AddStatusVm> Register(AddUser addUser)
        {

            AddStatusVm addStatus = new AddStatusVm();
            var result = await _userService.Register(addUser);
            addStatus.StatusMessage=result;
            if (result=="Successful")
            {
               
                addStatus.StatusCode=1;
            }
            else
            {
              addStatus.StatusCode = 4;
            }
            return addStatus;
        }


    }
}
