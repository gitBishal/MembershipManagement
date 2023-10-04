using Membership.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership.Application.ViewModels
{
    public class AddOrUpdateMembershipViewModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Guid DiscountTypeId { get; set; }
        public string? DiscountValue { get; set; }
    }
}
