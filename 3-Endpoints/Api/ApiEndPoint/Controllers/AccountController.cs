using ApiEndPoint.ViewModel;
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
            if (result == "Successful")
            {
               addStatus.IsValid = true;    
                addStatus.StatusMessage="Successful";
            }
            else
            {
                addStatus.IsValid=false;
                addStatus.StatusMessage="Error";
            }
            return addStatus;
        }


        [HttpPost("EditProfile")]
        public async Task<UpdateStatus> EditProfile(EditUserVm editUserVm)
        {

            UpdateStatus updateStatus = new UpdateStatus();
            var result = await _userService.EditProfile(editUserVm);

            return updateStatus;
        }

    }
}
