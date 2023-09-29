using Membership.Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Membership.ViewModels
{
    public class AddOrUpdateMembershipViewModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Guid DiscountTypeId { get; set; }
        public DiscountTypeDto DiscountTypeDTO { get; set; }   
        public string? DiscountValue { get; set; }
    }

    public class DiscountTypeDto
    {
        public string Name { get; set; }
    }
}
