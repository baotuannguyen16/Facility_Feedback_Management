using BusinessObject.Models;
using DataAccess.Repository;
using FontAwesome.Sharp;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FacilitiesFeedback
{
    public partial class frmMain : Form
    {
        private IconButton currentButton;
        private Form currentForm;

        public User user { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            this.IsMdiContainer = true;
            OpenFormHome();
            switch (user.Role)
            {
                case 0:
                    {
                        btnDevice.Visible = false;
                    }
                    break;
                case 1:
                    {

                    }
                    break;
                case 2:
                    {
                        btnDevice.Visible = false;
                    }
                    break;
                case 3:
                    {
                    }
                    break;
            }
        }

        private void OpenFormHome()
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmHome frmHome = new frmHome();
            btnTitle.Text = "Home";
            btnTitle.IconChar = IconChar.Home;
            frmHome.MdiParent = this;
            frmHome.StartPosition = FormStartPosition.Manual;
            frmHome.Show();
            panelDesktop.Controls.Add(frmHome);
            currentForm = frmHome;
            frmHome.Dock = DockStyle.Fill;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, System.EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMember_Click(object sender, System.EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            if (user.Role == 0 || user.Role == 3)
            {
                frmUserDetail frmUserDetail = new frmUserDetail
                {
                    user = new UserRepository().GetUserById(user.Id),
                };
                btnTitle.Text = "User Detail";
                btnTitle.IconChar = IconChar.User;
                frmUserDetail.MdiParent = this;
                frmUserDetail.StartPosition = FormStartPosition.Manual;
                frmUserDetail.Show();
                panelDesktop.Controls.Add(frmUserDetail);
                currentForm = frmUserDetail;
                frmUserDetail.Dock = DockStyle.Fill;

            }
            else
            {
                frmUserList frmUserList = new frmUserList()
                {
                    currentUser = user,
                };
                currentButton = btnMember;
                ChangeTitle();
                frmUserList.MdiParent = this;
                frmUserList.StartPosition = FormStartPosition.Manual;
                frmUserList.Show();
                panelDesktop.Controls.Add(frmUserList);
                currentForm = frmUserList;
                frmUserList.Dock = DockStyle.Fill;
            }
        }
        private void btnFeedback_Click(object sender, System.EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmFeedbackList frmFeedbackList = new frmFeedbackList
            {
                user = new UserRepository().GetUserById(user.Id),
            };
            currentButton = btnFeedback;
            ChangeTitle();
            frmFeedbackList.MdiParent = this;
            frmFeedbackList.StartPosition = FormStartPosition.Manual;
            frmFeedbackList.Show();
            panelDesktop.Controls.Add(frmFeedbackList);
            currentForm = frmFeedbackList;
            frmFeedbackList.Dock = DockStyle.Fill;
        }


        private void btnDevice_Click(object sender, System.EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmDeviceList frmDeviceList = new frmDeviceList();
            currentButton = btnDevice;
            ChangeTitle();
            frmDeviceList.MdiParent = this;
            frmDeviceList.StartPosition = FormStartPosition.Manual;
            frmDeviceList.Show();
            panelDesktop.Controls.Add(frmDeviceList);
            currentForm = frmDeviceList;
            frmDeviceList.Dock = DockStyle.Fill;
        }

        private void ChangeTitle()
        {
            btnTitle.Text = currentButton.Text;
            btnTitle.IconChar = currentButton.IconChar;
        }

        private void panelDesktop_Resize(object sender, System.EventArgs e)
        {
            foreach (Control item in panelDesktop.Controls)
            {
                var frm = (Form)item;
                frm.Dock = DockStyle.None;
                frm.Dock = DockStyle.Fill;
            }
        }

        private void pictureLogo_Click(object sender, System.EventArgs e)
        {
            OpenFormHome();
            pictureLogo.BackColor = Color.FromArgb(102, 102, 167, 255);
        }

        private void pictureLogo_MouseHover(object sender, System.EventArgs e)
        {
            pictureLogo.BackColor = Color.FromArgb(34, 34, 70, 255);
        }

        private void pictureLogo_MouseLeave(object sender, System.EventArgs e)
        {
            pictureLogo.BackColor = Color.Transparent;
        }

        private void btnLogout_Click(object sender, System.EventArgs e)
        {
            this.Close();
            new frmLogin().Show();
        }
    }
}
