using AutoMapper;
using Membership.Core.Entities;
using Membership.Core.Interfaces;
using Membership.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Membership.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipManagementController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMembershipService _membershipService;

        public MembershipManagementController(IMapper mapper,IMembershipService membershipService)
        {
            _mapper = mapper;
            _membershipService = membershipService;
        }
        [HttpPost,Route("addMembership")]
        public async Task<IActionResult> AddMembership([FromBody] AddOrUpdateMembershipViewModel addMembershipModel)
        {
            await _membershipService.AddMembershipAsync(_mapper.Map<Core.Entities.Membership>(addMembershipModel));
            return Ok(addMembershipModel);
        }
        [HttpPut, Route("updateMembership")]
        public async Task<IActionResult> UpdateMembership([FromBody] AddOrUpdateMembershipViewModel updateMembershipModel)
        {
            await _membershipService.UpdateMembershipAsync(_mapper.Map<Core.Entities.Membership>(updateMembershipModel));
            return Ok(updateMembershipModel);
        }
    }
}
