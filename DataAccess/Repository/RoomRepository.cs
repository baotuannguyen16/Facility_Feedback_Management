using BusinessObject.Models;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public class RoomRepository : IRoomRepository
    {
        public void AddRoom(Room room) => RoomDAO.Instance.AddRoom(room);

        public void DeleteRoom(Room room) => RoomDAO.Instance.DeleteRoom(room);

        public IEnumerable<Room> GetRooms() => RoomDAO.Instance.GetRooms();

        public void UpdateRoom(Room room) => RoomDAO.Instance.UpdateRoom(room);
    }
}
