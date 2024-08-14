
namespace Membership.Core.Interfaces
{
    public interface IMembershipRepository
    {
        Task<List<Entities.Membership>> GetAllMembershipsAsync();
        Task<Entities.Membership> GetAllMembershipsbyIDAsync(Guid id);
        Task<Entities.Membership> AddMembershipAsync(Entities.Membership membership);
        Task<Entities.Membership> UpdateMembershipAsync(Entities.Membership membership);
        Task<int> DeleteMembershipAsync(Guid id);

    }
}
