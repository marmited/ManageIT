using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ManageIt.Core.Context
{
    public class Request
    {
        [Key]
        public int RequestId { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeleteDate { get; set; }
        [ForeignKey("Users")]
        public int? UserId { get; set; }
        [ForeignKey("TimeSlots")]
        public int TimeSlotId { get; set; }
        public virtual TimeSlot TimeSlot { get; set; }
        public virtual User User { get; set; }

    }
}
