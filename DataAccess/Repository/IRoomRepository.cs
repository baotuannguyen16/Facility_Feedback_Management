using BusinessObject.Models;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public interface IRoomRepository
    {
        public IEnumerable<Room> GetRooms();
        public void AddRoom(Room room);
        public void UpdateRoom(Room room);
        public void DeleteRoom(Room room);
    }
}
