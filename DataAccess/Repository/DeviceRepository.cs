using BusinessObject.Models;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public class DeviceRepository : IDeviceRepository
    {
        public void AddDevice(Device device) => DeviceDAO.Instance.AddDevice(device);

        public void DeleteDevice(Device device) => DeviceDAO.Instance.DeleteDevice(device);

        public IEnumerable<Device> GetDevices() => DeviceDAO.Instance.GetDevices();

        public void UpdateDevice(Device device) => DeviceDAO.Instance.UpdateDevice(device);
        public Device GetDeviceById(int id) => DeviceDAO.Instance.GetDeviceById(id);
        public IEnumerable<Device> GetDevicesByRoomId(string roomNo) => DeviceDAO.Instance.GetDevicesByRoomId(roomNo);
    }
}
