using Mahface.Services.AppServices.Service;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Interface.IServices;
using Microsoft.AspNetCore.Mvc;

namespace ApiEndPoint.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherRequestController : ControllerBase
    {
        private readonly ITeacherRequestService _teacherRequestService;

        public TeacherRequestController(ITeacherRequestService service)
        {
            _teacherRequestService = service;
        }

        [HttpPost("CreateRequest")]
        public async Task<AddStatusVm> CreateRequest([FromBody] CreateTeacherRequestVm requestVm)
        {
            var result = await _teacherRequestService.CreateTeacherRequest(requestVm.UserId, requestVm.UserDescription);
          
            return result;
        }

        [HttpGet("GetAllRequests")]
        public async Task<IActionResult> GetAllRequests()
        {
            var requests = await _teacherRequestService.GetAllRequests();
            return Ok(requests);
        }

        [HttpGet("GetLastStatusForUser/{userId}")]
        public async Task<RequestStatus> GetAllRequests(Guid userId)
        {
             var result = await _teacherRequestService.GetUserTeacherRequestStatus(userId);
             return result;
        }


        [HttpPost("ApproveRequest/{requestId}")]
        public async Task<UpdateStatus> ApproveRequest(Guid requestId, Guid adminId)
        {
            var result = await _teacherRequestService.ApproveRequest(requestId, adminId);

            return result;
        }

        [HttpPost("RejectRequest/{requestId}")]
        public async Task<UpdateStatus> RejectRequest(Guid requestId, [FromBody] RejectRequestVm rejectVm)
        {
            var result = await _teacherRequestService.RejectRequest(requestId, rejectVm.AdminDescription, rejectVm.AdminId);
            return result;
        }


        [HttpPost("RejectMultiple")]
        public async Task<ActionResult<UpdateStatus>> RejectMultipleRequests([FromBody] RejectRequestsVm requestData)
        {
            var status = await _teacherRequestService.RejectMultipleRequests(requestData.RequestIds, requestData.AdminDescription, requestData.AdminId);

            if (!status.IsValid)
            {
                return BadRequest(status); // Return bad request if any of the requests failed
            }

            return Ok(status); // Return success if all requests were rejected
        }



        [HttpPost("ApproveMultiple")]
        public async Task<ActionResult<UpdateStatus>> ApproveMultipleRequests([FromBody] ApproveRequestsVm requestData)
        {
            var status = await _teacherRequestService.ApproveMultipleRequests(requestData.RequestIds, requestData.AdminId);

            if (!status.IsValid)
            {
                return BadRequest(status); // Return bad request if any of the requests failed
            }

            return Ok(status); // Return success if all requests were approved
        }

    }

}
