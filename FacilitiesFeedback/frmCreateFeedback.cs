using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Windows.Forms;

namespace FacilitiesFeedback
{
    public partial class frmCreateFeedback : Form
    {
        IFeedbackRepository feedbackRepository = new FeedbackRepository();
        public User user { get; set; }

        public frmCreateFeedback()
        {
            InitializeComponent();
        }

        private void frmCreateFeedback_Load(object sender, EventArgs e)
        {
            var roomList = new RoomRepository().GetRooms();
            cboxRoom.DataSource = roomList;
            cboxRoom.ValueMember = "RoomNo";
            cboxRoom.DisplayMember = "RoomNo";
        }

        private void cboxRoom_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var deviceList = new DeviceRepository().GetDevicesByRoomId(cboxRoom.SelectedValue.ToString());
            cboxDeviceName.DataSource = null;
            cboxDeviceName.DataSource = deviceList;
            cboxDeviceName.ValueMember = "Id";
            cboxDeviceName.DisplayMember = "Name";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                string nowString = now.ToString("dd-MM-yyyy");
                if (cboxDeviceName.SelectedValue == null)
                {
                    throw new Exception("You need to select device");
                }
                Feedback feedback = new Feedback
                {
                    Content = txtContent.Texts,
                    CreateDate = nowString,
                    DeviceId = Int32.Parse(cboxDeviceName.SelectedValue.ToString()),
                    StaffId = null,
                    Status = 0,
                    Reply = "",
                    UserId = user.Id,
                };

                feedbackRepository.AddFeedback(feedback);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                new frmMessageBox(ex.Message).ShowDialog();
            }
        }
    }
}
