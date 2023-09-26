
namespace Membership.Core.Interfaces
{
    public interface IMembershipService
    {
        Task<Core.Entities.Membership> GetAllMembershipsAsync();
        Task<Core.Entities.Membership> AddMembershipAsync();
        Task<Core.Entities.Membership> UpdateMembershipAsync();

    }
}
