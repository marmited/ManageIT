using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ManageIt.Core.Context
{
    public class Correspondence
    {
        [Key]
        public int CorrespondenceId { get; set; }
        [ForeignKey("Users")]
        public int SourceUserId { get; set; }
        public virtual User SourceUser { get; set; }
        [ForeignKey("Users")]
        public int TargetUserId { get; set; }
        public virtual User TargetUser { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeleteDate { get; set; }



    }
}
