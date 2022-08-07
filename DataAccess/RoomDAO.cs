using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class RoomDAO
    {
        //Singleton 
        private static RoomDAO instance;
        public static readonly object instanceLock = new object();
        private RoomDAO() { }
        public static RoomDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new RoomDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Room> GetRooms()
        {
            List<Room> Rooms;

            try
            {
                using (var context = new FeedbackDBContext())
                {
                    Rooms = context.Rooms.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Rooms;
        }

        public void AddRoom(Room room)
        {
            try
            {
                using (var context = new FeedbackDBContext())
                {
                    if (context.Rooms.SingleOrDefault(value => value.RoomNo == room.RoomNo) != null)
                    {
                        throw new Exception("This Id was existed");
                    }
                    context.Rooms.Add(room);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateRoom(Room room)
        {
            try
            {
                using (var context = new FeedbackDBContext())
                {
                    context.Entry<Room>(room).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteRoom(Room room)
        {
            try
            {
                using (var context = new FeedbackDBContext())
                {
                    var _room = context.Rooms.SingleOrDefault(value => value.RoomNo == room.RoomNo);
                    context.Rooms.Remove(_room);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
