using Membership.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership.Infrastructure.Repositories
{
    public class MembershipService : IMembershipService
    {
        private readonly AppDbContext _context;
        public MembershipService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Core.Entities.Membership> AddMembershipAsync(Core.Entities.Membership membership)
        {
            await _context.Memberships.AddAsync(membership);
            await _context.SaveChangesAsync();
            return membership;
        }

        public async Task<IEnumerable<Core.Entities.Membership>> GetAllMembershipsAsync() =>
            await _context.Memberships.AsNoTracking().Include(x => x.DiscountType).ToListAsync();
       

        public Task<Core.Entities.Membership> UpdateMembershipAsync(Core.Entities.Membership membership )
        {
            throw new NotImplementedException();
        }
    }
}
