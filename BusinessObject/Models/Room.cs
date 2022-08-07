using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class Room
    {
        public Room()
        {
            Devices = new HashSet<Device>();
        }

        public string RoomNo { get; set; }
        public int Floor { get; set; }

        public virtual ICollection<Device> Devices { get; set; }
    }
}
