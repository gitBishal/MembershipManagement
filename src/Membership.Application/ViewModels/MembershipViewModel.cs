using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership.Application.ViewModels
{
    public class MembershipViewModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Guid DiscountTypeId { get; set; }
        public string? DiscountValue { get; set; }
    }
}
