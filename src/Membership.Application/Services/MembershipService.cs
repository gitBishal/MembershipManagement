using AutoMapper;
using Membership.Application.Interfaces;
using Membership.Application.ViewModels;
using Membership.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership.Application.Services
{
    public class MembershipService : IMembershipService
    {
        private readonly IMembershipRepository _membershipRepository;
        private readonly IMapper _mapper;
        public MembershipService(IMembershipRepository membershipRepository,IMapper mapper)
        {
                _mapper = mapper;
               _membershipRepository = membershipRepository;
        }
        public async Task<AddOrUpdateMembershipViewModel> AddMembershipAsync(AddOrUpdateMembershipViewModel membership)
        {
            await _membershipRepository.AddMembershipAsync(_mapper.Map<Core.Entities.Membership>(membership));
            return membership;
        }

        public async Task<int> DeleteMembershipAsync(Guid id) => await _membershipRepository.DeleteMembershipAsync(id);

        public Task<List<MembershipViewModel>> GetAllMembershipsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<AddOrUpdateMembershipViewModel> UpdateMembershipAsync(AddOrUpdateMembershipViewModel membership)
        {
            await _membershipRepository.UpdateMembershipAsync(_mapper.Map<Core.Entities.Membership>(membership));
            return membership;
        }
    }
}
