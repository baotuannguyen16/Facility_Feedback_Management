namespace FacilitiesFeedback
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new FacilitiesFeedback.UIControl.CustomizeButton();
            this.btnDevice = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnFeedback = new FontAwesome.Sharp.IconButton();
            this.btnMember = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnTitle = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnDevice);
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Controls.Add(this.btnFeedback);
            this.panelMenu.Controls.Add(this.btnMember);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(160, 699);
            this.panelMenu.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(175)))), ((int)(((byte)(71)))));
            this.btnLogout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(175)))), ((int)(((byte)(71)))));
            this.btnLogout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogout.BorderRadius = 10;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(26, 648);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(107, 41);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextColor = System.Drawing.Color.White;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDevice
            // 
            this.btnDevice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDevice.FlatAppearance.BorderSize = 0;
            this.btnDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevice.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDevice.ForeColor = System.Drawing.Color.White;
            this.btnDevice.IconChar = FontAwesome.Sharp.IconChar.Desktop;
            this.btnDevice.IconColor = System.Drawing.Color.White;
            this.btnDevice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDevice.IconSize = 35;
            this.btnDevice.Location = new System.Drawing.Point(0, 293);
            this.btnDevice.Name = "btnDevice";
            this.btnDevice.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.btnDevice.Size = new System.Drawing.Size(160, 87);
            this.btnDevice.TabIndex = 3;
            this.btnDevice.Text = "Device";
            this.btnDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDevice.UseVisualStyleBackColor = true;
            this.btnDevice.Click += new System.EventHandler(this.btnDevice_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(12, -927);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 203);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnFeedback
            // 
            this.btnFeedback.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFeedback.FlatAppearance.BorderSize = 0;
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFeedback.ForeColor = System.Drawing.Color.White;
            this.btnFeedback.IconChar = FontAwesome.Sharp.IconChar.Message;
            this.btnFeedback.IconColor = System.Drawing.Color.White;
            this.btnFeedback.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFeedback.IconSize = 35;
            this.btnFeedback.Location = new System.Drawing.Point(0, 206);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.btnFeedback.Size = new System.Drawing.Size(160, 87);
            this.btnFeedback.TabIndex = 2;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnMember
            // 
            this.btnMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMember.FlatAppearance.BorderSize = 0;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMember.ForeColor = System.Drawing.Color.White;
            this.btnMember.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnMember.IconColor = System.Drawing.Color.White;
            this.btnMember.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMember.IconSize = 35;
            this.btnMember.Location = new System.Drawing.Point(0, 119);
            this.btnMember.Name = "btnMember";
            this.btnMember.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.btnMember.Size = new System.Drawing.Size(160, 87);
            this.btnMember.TabIndex = 1;
            this.btnMember.Text = "Member";
            this.btnMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureLogo);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(160, 119);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(8, 9);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(145, 103);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 1;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.Click += new System.EventHandler(this.pictureLogo_Click);
            this.pictureLogo.MouseLeave += new System.EventHandler(this.pictureLogo_MouseLeave);
            this.pictureLogo.MouseHover += new System.EventHandler(this.pictureLogo_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, -642);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.btnTitle);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Location = new System.Drawing.Point(160, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1122, 66);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnTitle
            // 
            this.btnTitle.FlatAppearance.BorderSize = 0;
            this.btnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTitle.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnTitle.IconColor = System.Drawing.Color.Black;
            this.btnTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTitle.IconSize = 30;
            this.btnTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitle.Location = new System.Drawing.Point(6, 19);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(148, 37);
            this.btnTitle.TabIndex = 6;
            this.btnTitle.Text = "Home";
            this.btnTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTitle.UseVisualStyleBackColor = true;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMinimize.IconSize = 30;
            this.btnMinimize.Location = new System.Drawing.Point(1023, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 25);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMaximize.IconSize = 30;
            this.btnMaximize.Location = new System.Drawing.Point(1057, 1);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(28, 25);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnExit.IconSize = 30;
            this.btnExit.Location = new System.Drawing.Point(1091, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 25);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panelDesktop.Location = new System.Drawing.Point(160, 62);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1119, 637);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.Resize += new System.EventHandler(this.panelDesktop_Resize);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1279, 699);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnMember;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnFeedback;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.PictureBox pictureLogo;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnTitle;
        private FontAwesome.Sharp.IconButton btnDevice;
        private UIControl.CustomizeButton btnLogout;
    }
}
