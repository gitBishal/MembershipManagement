using Membership.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership.Application.Interfaces
{
    public interface IMembershipService
    {
        Task<List<MembershipViewModel>> GetAllMembershipsAsync();
        Task<AddOrUpdateMembershipViewModel> AddMembershipAsync(AddOrUpdateMembershipViewModel membership);
        Task<AddOrUpdateMembershipViewModel> UpdateMembershipAsync(AddOrUpdateMembershipViewModel membership);
        Task<int> DeleteMembershipAsync(Guid id);
    }
}
