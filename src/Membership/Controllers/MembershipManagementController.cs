using Membership.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Membership.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipManagementController : ControllerBase
    {
        public MembershipManagementController()
        {

        }
        public async Task<IActionResult> Membership()
        {
            var response = new ApiResponse();
            return Ok(response);
        }
    }
}
