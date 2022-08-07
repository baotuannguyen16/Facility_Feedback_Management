using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class Device
    {
        public Device()
        {
            Feedbacks = new HashSet<Feedback>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string RoomNo { get; set; }
        public int? Status { get; set; }
        public string Type { get; set; }

        public virtual Room RoomNoNavigation { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
