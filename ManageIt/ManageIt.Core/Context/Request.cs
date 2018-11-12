using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ManageIt.Core.Context
{
    public class Request
    {
        public int RequestId { get; set; }
        public User Requester { get; set; }
        [Required]
        public User Owner { get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeleteDate { get; set; }
    }
}
