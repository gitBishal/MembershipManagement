using Membership.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership.Infrastructure.Repositories
{
    public class MembershipService : IMembershipService
    {
        public Task<Core.Entities.Membership> AddMembershipAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Core.Entities.Membership> GetAllMembershipsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Core.Entities.Membership> UpdateMembershipAsync()
        {
            throw new NotImplementedException();
        }
    }
}
