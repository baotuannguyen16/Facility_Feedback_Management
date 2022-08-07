using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FacilitiesFeedback
{
    public partial class frmFeedbackDetail : Form
    {
        IUserRepository userRepository = new UserRepository();
        IFeedbackRepository feedbackRepository = new FeedbackRepository();
        IDeviceRepository deviceRepository = new DeviceRepository();
        public User user { get; set; }
        public Feedback feedback { get; set; }

        public frmFeedbackDetail()
        {
            InitializeComponent();
        }

        private void frmFeedbackDetail_Load(object sender, System.EventArgs e)
        {
            var staffList = userRepository.GetUsers().Where(x => x.Role == 3).ToList();
            cboxStaff.DataSource = staffList;
            cboxStaff.ValueMember = "Id";
            cboxStaff.DisplayMember = "Name";

            var statusList = new[]
            {
                new { Status = 0, StatusName = "Processing" },
                new { Status = 1, StatusName = "Aproved"},
                new { Status = 2, StatusName = "Rejected"},
            }.ToList();
            cboxStatus.DataSource = statusList;
            cboxStatus.ValueMember = "Status";
            cboxStatus.DisplayMember = "StatusName";

            var deviceStatusList = new[]
            {
                new { DeviceStatus = 0, DeviceStatusName = "Faulty"},
                new { DeviceStatus = 1, DeviceStatusName = "Correcting"},
                new { DeviceStatus = 2, DeviceStatusName = "Normal"}
            }.ToList();
            cboxDeviceStatus.DataSource = deviceStatusList;
            cboxDeviceStatus.ValueMember = "DeviceStatus";
            cboxDeviceStatus.DisplayMember = "DeviceStatusName";
            AddData();
            DisableTexts();

        }

        private void AddData()
        {
            txtId.Texts = feedback.Id.ToString();
            txtCreatedDate.Texts = feedback.CreateDate.ToString();
            cboxStatus.Texts = feedback.Status == 0 ? "Processing" : feedback.Status == 1 ? "Aproved" : "Rejected";
            txtContent.Texts = feedback.Content;
            txtReply.Texts = feedback.Reply;
            //User
            txtUserId.Texts = feedback.UserId.ToString();
            txtUserName.Texts = userRepository.GetUserById((int)feedback.UserId).Name.ToString();

            //Device
            Device device = deviceRepository.GetDeviceById((int)feedback.DeviceId);
            txtDeviceId.Texts = device.Id.ToString();
            txtDeviceName.Texts = device.Name.ToString();
            txtRoom.Texts = device.RoomNo.ToString();
            cboxDeviceStatus.SelectedValue = device.Status == 0 ? 0 : device.Status == 1 ? 1 : 2;

            //Staff
            if (feedback.StaffId == null)
            {
                cboxStaff.Texts = "";
            }
            else
            {
                cboxStaff.Texts = userRepository.GetUserById((int)feedback.StaffId).Name;
            }
        }


        private void DisableTexts()
        {
            //Feedback
            txtId.Enabled = false;
            txtCreatedDate.Enabled = false;
            txtContent.Enabled = false;
            txtReply.Enabled = false;
            cboxStatus.Enabled = false;

            //User
            txtUserId.Enabled = false;
            txtUserName.Enabled = false;

            //Device
            txtDeviceName.Enabled = false;
            txtDeviceId.Enabled = false;
            txtRoom.Enabled = false;
            cboxDeviceStatus.Enabled = false;

            //Staff
            cboxStaff.Enabled = false;

            if (user.Role == 0)
            {
                btnSave.Enabled = false;
            }

        }
        private void EnableTexts()
        {

            if (user.Role != 0)
            {
                txtReply.Enabled = true;
                cboxStaff.Enabled = true;
                cboxStatus.Enabled = true;
            }
            if (user.Role == 3)
            {
                cboxDeviceStatus.Enabled = true;
                btnSave.Enabled = false;

            }
            if (cboxStatus.Texts.Equals("Processing") && user.Role != 3)
            {
                new frmMessageBox("You must call Engineer to fix device").ShowDialog();
            }
            if (user.Status == 1)
            {
                new frmMessageBox("You are banned! Cannot edit feedback").ShowDialog();
                btnSave.Enabled = false;
            }

        }

        private Feedback GetFeedback()
        {
            Feedback feedback = null;
            try
            {
                feedback = new Feedback
                {
                    Id = Int32.Parse(txtId.Texts),
                    CreateDate = txtCreatedDate.Texts,
                    UserId = Int32.Parse(txtUserId.Texts),
                    Content = txtContent.Texts,
                    DeviceId = Int32.Parse(txtDeviceId.Texts),
                    StaffId = Int32.Parse(cboxStaff.SelectedValue.ToString()),
                    Status = Int32.Parse(cboxStatus.SelectedValue.ToString()),
                    Reply = txtReply.Texts,
                };
            }
            catch (Exception ex)
            {
                new frmMessageBox(ex.Message).ShowDialog();
            }
            return feedback;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (btnSave.Text.Equals("Edit"))
                {
                    btnSave.Text = "Save";
                    EnableTexts();
                }
                else
                {
                    Feedback feedback = GetFeedback();
                    if (feedback == null)
                    {
                        return;
                    }
                    Device device = deviceRepository.GetDeviceById((int)feedback.DeviceId);
                    device.Status = Int32.Parse(cboxDeviceStatus.SelectedValue.ToString());
                    deviceRepository.UpdateDevice(device);
                    feedbackRepository.UpdateFeedback(feedback);
                    DisableTexts();
                    btnSave.Text = "Edit";
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                new frmMessageBox(ex.Message).ShowDialog();
            }

        }

        private void customizeButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboxDeviceStatus_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }
    }

}
