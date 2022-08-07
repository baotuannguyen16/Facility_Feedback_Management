using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FacilitiesFeedback
{
    public partial class frmDeviceList : Form
    {
        IDeviceRepository deviceRepository = new DeviceRepository();
        List<Device> deviceList = new List<Device>();
        public frmDeviceList()
        {
            InitializeComponent();
        }

        private void frmDeviceList_Load(object sender, System.EventArgs e)
        {
            ShowData();
            var statusList = new[]
            {
                new { status = "Faulty", value = 0},
                new { status = "Correcting", value = 1},
                new { status = "Normal", value = 2},
            };
            cboxFilter.DataSource = statusList;
            cboxFilter.ValueMember = "value";
            cboxFilter.DisplayMember = "status";
        }

        private void ShowData()
        {
            deviceList = (List<Device>)deviceRepository.GetDevices();
            dgvDevice.DataSource = null;
            dgvDevice.DataSource = deviceList;
            dgvDevice.Columns["RoomNoNavigation"].Visible = false;
            dgvDevice.Columns["Feedbacks"].Visible = false;
        }

        private void ShowData(List<Device> _deviceList)
        {
            deviceList = (List<Device>)deviceRepository.GetDevices();
            dgvDevice.DataSource = null;
            dgvDevice.DataSource = _deviceList;
            dgvDevice.Columns["RoomNoNavigation"].Visible = false;
            dgvDevice.Columns["Feedbacks"].Visible = false;
        }

        private void btnFilter_Click(object sender, System.EventArgs e)
        {
            try
            {
                var deviceListFilter = (List<Device>)deviceRepository.GetDevices().Where(x => x.Status == Int32.Parse(cboxFilter.SelectedValue.ToString())).ToList();
                ShowData(deviceListFilter);
            }
            catch (Exception ex)
            {
                new frmMessageBox(ex.Message).ShowDialog();
            }
        }
    }
}
