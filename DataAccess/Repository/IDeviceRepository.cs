using BusinessObject.Models;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public interface IDeviceRepository
    {
        public IEnumerable<Device> GetDevices();
        public void AddDevice(Device device);
        public void UpdateDevice(Device device);
        public void DeleteDevice(Device device);
        public Device GetDeviceById(int id);
        public IEnumerable<Device> GetDevicesByRoomId(string roomNo);
    }
}
