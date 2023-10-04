using Membership.Application.Interfaces;
using Membership.Application.ViewModels;
using Membership.Core.Entities;
using Membership.Infrastructure.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Membership.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipManagementController : ControllerBase
    {
        private readonly IMembershipService _membershipService;

        public MembershipManagementController(IMembershipService membershipService)
        {
            _membershipService = membershipService;
        }
        [HttpPost,Route("addMembership")]
        public async Task<IActionResult> AddMembership([FromBody] AddOrUpdateMembershipViewModel addMembershipModel)
        {
            return Ok(await _membershipService.AddMembershipAsync(addMembershipModel));
        }
        [HttpPut, Route("updateMembership")]
        public async Task<IActionResult> UpdateMembership([FromBody] AddOrUpdateMembershipViewModel updateMembershipModel)
        {
            return Ok(await _membershipService.UpdateMembershipAsync(updateMembershipModel));
        }
        [HttpDelete,Route("deleteMembership")]
        public async Task<IActionResult> DeleteMembership(Guid id)
        {
            var result = await _membershipService.DeleteMembershipAsync(id);
            return Ok("Deleted successfully");
        }
    }
}
