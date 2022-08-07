using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class Feedback
    {
        public int Id { get; set; }
        public string CreateDate { get; set; }
        public int? UserId { get; set; }
        public string Content { get; set; }
        public string Reply { get; set; }
        public int? DeviceId { get; set; }
        public int? StaffId { get; set; }
        public int? Status { get; set; }

        public virtual Device Device { get; set; }
        public virtual User Staff { get; set; }
        public virtual User User { get; set; }
    }
}
