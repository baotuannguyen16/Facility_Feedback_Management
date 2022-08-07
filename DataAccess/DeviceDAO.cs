using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class DeviceDAO
    {
        //Singleton 
        private static DeviceDAO instance;
        public static readonly object instanceLock = new object();
        private DeviceDAO() { }
        public static DeviceDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new DeviceDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Device> GetDevices()
        {
            List<Device> devices;

            try
            {
                using (var context = new FeedbackDBContext())
                {
                    devices = context.Devices.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return devices;
        }

        public void AddDevice(Device device)
        {
            try
            {
                using (var context = new FeedbackDBContext())
                {
                    if (context.Devices.SingleOrDefault(value => value.Id == device.Id) != null)
                    {
                        throw new Exception("This Id was existed");
                    }
                    context.Devices.Add(device);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateDevice(Device device)
        {
            try
            {
                using (var context = new FeedbackDBContext())
                {
                    context.Entry<Device>(device).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteDevice(Device device)
        {
            try
            {
                using (var context = new FeedbackDBContext())
                {
                    var _device = context.Devices.SingleOrDefault(value => value.Id == device.Id);
                    context.Devices.Remove(_device);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Device GetDeviceById(int id)
        {
            List<Device> deviceList = GetDevices();
            Device device = deviceList.SingleOrDefault(value => value.Id == id);
            return device;
        }

        public List<Device> GetDevicesByRoomId(string roomNo)
        {
            List<Device> deviceList = GetDevices();
            List<Device> deviceList_sub = deviceList.Where(x => x.RoomNo.Equals(roomNo)).ToList();
            return deviceList_sub;
        }
    }
}
