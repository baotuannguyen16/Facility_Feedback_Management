using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FacilitiesFeedback
{
    public partial class frmUserDetail : Form
    {
        IUserRepository userRepository = new UserRepository();
        public User adminUser { get; set; }
        public User user { get; set; }
        public bool isAdmin { get; set; }

        public frmUserDetail()
        {
            InitializeComponent();
        }

        private void frmUserDetail_Load(object sender, System.EventArgs e)
        {

            var roleList = new[]
            {
                new { Role = 0, RoleName = "User" },
                new { Role = 1, RoleName =  "Administrator's Manager"},
                new { Role = 2, RoleName = "Administrator's Staff"},
                new { Role = 3, RoleName = "Engineer Staff"}
            }.ToList();
            cboxRole.DataSource = roleList;
            cboxRole.ValueMember = "Role";
            cboxRole.DisplayMember = "RoleName";
            var statusList = new[]
            {
                new { Status = 0, StatusName = "Active" },
                new { Status = 1, StatusName = "Inactive"},
            }.ToList();
            cboxStatus.DataSource = statusList;
            cboxStatus.ValueMember = "Status";
            cboxStatus.DisplayMember = "StatusName";
            AddData();
            DisableTexts();
        }

        private void AddData()
        {
            txtEmail.Texts = user.Email;
            txtPassword.Texts = user.Password;
            txtId.Texts = user.Id.ToString();
            txtName.Texts = user.Name;
            txtPhone.Texts = user.Phone;
            cboxRole.SelectedIndex = user.Role == 0 ? 0 : user.Role == 1 ? 1 : user.Role == 2 ? 2 : 3;
            cboxStatus.Texts = user.Status == 0 ? "Active" : "Inactive";
        }

        private void DisableTexts()
        {
            txtEmail.Enabled = false;
            txtPassword.Enabled = false;
            txtId.Enabled = false;
            txtName.Enabled = false;
            txtPhone.Enabled = false;
            cboxRole.Enabled = false;
            cboxStatus.Enabled = false;
        }
        private void EnableTexts()
        {
            txtPassword.Enabled = true;
            txtName.Enabled = true;
            txtPhone.Enabled = true;
            if (isAdmin)
            {
                cboxRole.Enabled = true;
                cboxStatus.Enabled = true;
            }

        }

        private User GetUser()
        {
            User user = null;
            try
            {
                if (txtName.Texts.Equals("") || txtPassword.Texts.Equals(""))
                {
                    throw new Exception("Name and Password field required! Try again");
                    return null;
                }

                user = new User
                {
                    Id = Int32.Parse(txtId.Texts),
                    Name = txtName.Texts,
                    Phone = txtPhone.Texts,
                    Email = txtEmail.Texts,
                    Password = txtPassword.Texts,
                    Role = Int32.Parse(cboxRole.SelectedValue.ToString()),
                    Status = Int32.Parse(cboxStatus.SelectedValue.ToString())
                };
            }
            catch (Exception ex)
            {
                new frmMessageBox(ex.Message).ShowDialog();
            }
            return user;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (btnSave.Text.Equals("Edit"))
            {
                btnSave.Text = "Save";
                EnableTexts();
            }
            else
            {
                User userSub = GetUser();

                if (user.Role == 0 && adminUser == null)
                {
                    user = userSub;
                    userRepository.UpdateUser(user);
                    DisableTexts();
                    btnSave.Text = "Edit";
                    this.DialogResult = DialogResult.OK;
                    return;
                }
                if (user.Role < adminUser.Role && user.Role > 0)
                {
                    new frmMessageBox("This User has higher Role, you cannot edit!").ShowDialog();
                    return;
                }
                if (userSub == null)
                {
                    return;
                }
                user = userSub;
                userRepository.UpdateUser(user);
                DisableTexts();
                btnSave.Text = "Edit";
                this.DialogResult = DialogResult.OK;
            }

        }

        private void customizeButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
