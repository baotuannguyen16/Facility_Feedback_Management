using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FacilitiesFeedback
{
    public partial class frmUserList : Form
    {
        IUserRepository userRepository = new UserRepository();
        public User currentUser { get; set; }
        List<User> userList = new List<User>();

        bool IsLoaded = false;
        int CurrentRow;
        public frmUserList()
        {
            InitializeComponent();

        }

        private void frmUserList_Load(object sender, System.EventArgs e)
        {

            ShowData();
            cboxFilter.Items.Add("Role");
            cboxFilter.Items.Add("Status");
            IsLoaded = true;
        }

        private void ShowData()
        {
            userList = (List<User>)userRepository.GetUsers();
            dgvUser.DataSource = null;
            dgvUser.DataSource = userList;
            dgvUser.Columns["FeedbackStaffs"].Visible = false;
            dgvUser.Columns["FeedbackUsers"].Visible = false;
        }
        private void ShowData(List<User> users)
        {
            dgvUser.DataSource = null;
            dgvUser.DataSource = users;
            dgvUser.Columns["FeedbackStaffs"].Visible = false;
            dgvUser.Columns["FeedbackUsers"].Visible = false;
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
            {
                return;
            }
            frmUserDetail frmUserDetail = new frmUserDetail
            {
                adminUser = currentUser,
                user = (User)dgvUser.Rows[e.RowIndex].DataBoundItem,
                isAdmin = true,
            };
            if (frmUserDetail.ShowDialog() == DialogResult.OK)
            {
                ShowData();
                dgvUser.CurrentCell = dgvUser.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            try
            {
                var userInList = (User)dgvUser.Rows[CurrentRow].DataBoundItem;
                if (userInList.Id == currentUser.Id)
                {
                    throw new Exception("This is your account! Cannot Delete");
                }
                if (userInList.Role > 0 && userInList.Role < currentUser.Role)
                {
                    throw new Exception("You do not have permissions to delete this user!");
                }
                var Confirm = MessageBox.Show("Are you want to delete this User?", "Confirm Delete!!!", MessageBoxButtons.YesNo);
                if (Confirm == DialogResult.Yes)
                {
                    userRepository.DeleteUser(userInList);
                    MessageBox.Show("Delete Successful", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData();
                }
            }
            catch (Exception ex)
            {
                new frmMessageBox(ex.Message).ShowDialog();
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrentRow = e.RowIndex;
        }

        private void cboxFilter_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsLoaded)
            {
                return;
            }
            if (cboxFilter.Texts.Equals("Status"))
            {
                FilterContent_Status();
            }
            else if (cboxFilter.Texts.Equals("Role"))
            {
                FilterContent_Role();
            }
        }

        private void FilterContent_Status()
        {
            var statusList = new[]
            {
                new {Status = 0, Name = "Active"},
                new {Status = 1, Name = "Inactive"}
            }.ToList();
            cboxFilterContent.DataSource = null;
            cboxFilterContent.DataSource = statusList;
            cboxFilterContent.ValueMember = "Status";
            cboxFilterContent.DisplayMember = "Name";
        }
        private void FilterContent_Role()
        {
            var roleList = new[]
            {
                new { Role = 0, RoleName = "User" },
                new { Role = 1, RoleName =  "Administrator's Manager"},
                new { Role = 2, RoleName = "Administrator's Staff"},
                new { Role = 3, RoleName = "Engineer Staff"}
            }.ToList();
            cboxFilterContent.DataSource = null;
            cboxFilterContent.DataSource = roleList;
            cboxFilterContent.ValueMember = "Role";
            cboxFilterContent.DisplayMember = "RoleName";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cboxFilter.Texts.Equals("Status"))
            {
                List<User> userListFilter = userList.Where(x => x.Status == Int32.Parse(cboxFilterContent.SelectedValue.ToString())).ToList();
                ShowData(userListFilter);
            }
            else if (cboxFilter.Texts.Equals("Role"))
            {
                List<User> userListFilter = userList.Where(x => x.Role == Int32.Parse(cboxFilterContent.SelectedValue.ToString())).ToList();
                ShowData(userListFilter);
            }
        }
    }
}
