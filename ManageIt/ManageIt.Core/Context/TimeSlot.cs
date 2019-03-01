using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ManageIt.Core.Context
{
    public class TimeSlot
    {
        [Key]
        public int TimeSlotId { get; set; }
        [Required]
        [ForeignKey("Users")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeleteDate { get; set; }

        ////Foreign keys
        //[ForeignKey("UserId")]
        //public User User { get; set; }
        //[ForeignKey("RequestId")]
        //public Request Request { get; set; }

    }
}
