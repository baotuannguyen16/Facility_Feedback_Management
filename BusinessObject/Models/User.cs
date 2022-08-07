using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class User
    {
        public User()
        {
            FeedbackStaffs = new HashSet<Feedback>();
            FeedbackUsers = new HashSet<Feedback>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public int? Status { get; set; }
        public int? Role { get; set; }

        public virtual ICollection<Feedback> FeedbackStaffs { get; set; }
        public virtual ICollection<Feedback> FeedbackUsers { get; set; }
    }
}
