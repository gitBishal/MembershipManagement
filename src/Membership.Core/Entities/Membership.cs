using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership.Core.Entities
{
    public class Membership : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        [ForeignKey("DiscountTypeId")]
        public Guid DiscountTypeId { get; set; }
        public virtual DiscountType DiscountType { get; set; }
        public string? DiscountValue { get; set; }
    }
}
