using Membership.Core.Entities;
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

        public async Task<int> DeleteMembershipAsync(Guid id)
        {
            var memberShipToDelete = await _context.Memberships.FirstOrDefaultAsync(x => x.Id == id) ?? throw new Exception("Failed to delete");
             _context.Memberships.Remove(memberShipToDelete);
            return await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Core.Entities.Membership>> GetAllMembershipsAsync() =>
            await _context.Memberships.AsNoTracking().Include(x => x.DiscountType).ToListAsync();
       

        public async Task<Core.Entities.Membership> UpdateMembershipAsync(Core.Entities.Membership memberShip )
        {
            var memberShipFromDb = await _context.Memberships.FirstOrDefaultAsync(x => x.Id == memberShip.Id) ?? throw new Exception("Failed to update");
            memberShipFromDb.Name = memberShip.Name;
            memberShipFromDb.Description = memberShip.Description;
            memberShip.DiscountValue = memberShipFromDb.DiscountValue;
            memberShip.DiscountTypeId = memberShipFromDb.DiscountTypeId;
            _context.Memberships.Update(memberShipFromDb);
            await _context.SaveChangesAsync();
            return memberShip;
        }
    }
}
