using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ManageIt.Core.Context
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        public int OrderNumber { get; set; }
        [ForeignKey("Correspondences")]
        public int CorrespondenceId { get; set; }
        public virtual Correspondence Correspondence { get; set; }
        [ForeignKey("Users")]
        public int SourceUserId { get; set; }
        public virtual User SourceUser { get; set; }
        [ForeignKey("Users")]
        public int TargetUserId { get; set; }
        public virtual User TargetUser { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
