using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FacilitiesFeedback
{
    public partial class frmCreateUser : Form
    {
        IUserRepository userRepository = new UserRepository();
        public frmCreateUser()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Texts.Equals("") || txtName.Texts.Equals("")
                    || txtPassword.Texts.Equals("") || txtRePassword.Texts.Equals(""))
                {
                    throw new Exception("All field required!");
                }

                if (!Regex.IsMatch(txtEmail.Texts, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase))
                {
                    throw new Exception("Wrong email format!");
                }

                if (!txtPassword.Texts.Equals(txtRePassword.Texts))
                {
                    throw new Exception("Password is not maching with Re-Password");
                }

                User user = new User
                {
                    Email = txtEmail.Texts,
                    Name = txtName.Texts,
                    Password = txtPassword.Texts,
                    Role = 0,
                    Status = 0,
                };

                userRepository.AddUser(user);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                new frmMessageBox(ex.Message).ShowDialog();
            }
        }
    }
}
