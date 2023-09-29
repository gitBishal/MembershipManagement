
namespace Membership.Core.Interfaces
{
    public interface IMembershipService
    {
        Task<IEnumerable<Entities.Membership>> GetAllMembershipsAsync();
        Task<Entities.Membership> AddMembershipAsync(Entities.Membership membership);
        Task<Entities.Membership> UpdateMembershipAsync(Entities.Membership membership);
        Task<int> DeleteMembershipAsync(Guid id);

    }
}
