using BusinessObject.Models;
using DataAccess.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FacilitiesFeedback
{
    public partial class frmLogin : Form
    {
        IUserRepository userRepository = new UserRepository();
        List<User> userList = new List<User>();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLoginExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            string email = txtEmail.Texts;
            string password = txtPassword.Texts;

            if (email.Trim().Equals("") || password.Equals(""))
            {
                new frmMessageBox("All field required! Try again").ShowDialog();
                return;
            }

            userList = (List<User>)userRepository.GetUsers();
            User user = userList.SingleOrDefault(value => (value.Email.Equals(email) && value.Password.Equals(password)));

            if (user == null)
            {
                new frmMessageBox("Wrong email or password! Try again").ShowDialog();
                return;
            }

            this.Hide();
            frmMain frmMain = new frmMain
            {
                user = user,
            };
            frmMain.Show();


        }

        private void linklbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCreateUser frmCreateUser = new frmCreateUser();
            if (frmCreateUser.ShowDialog() == DialogResult.OK)
            {
                new frmMessageBox("Create account successfully! Please login to use system").ShowDialog();
            }
        }
    }
}
