namespace FacilitiesFeedback
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new FacilitiesFeedback.UIControl.CustomTextbox();
            this.txtPassword = new FacilitiesFeedback.UIControl.CustomTextbox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnLogin = new FacilitiesFeedback.UIControl.CustomizeButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnLoginExit = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.linklbRegister = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FacilitiesFeedback.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 429);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(451, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Login";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(58)))), ((int)(((byte)(45)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderSize = 4;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Location = new System.Drawing.Point(450, 191);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(256, 40);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(58)))), ((int)(((byte)(45)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassword.BorderSize = 4;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Location = new System.Drawing.Point(450, 251);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(256, 40);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.Enabled = false;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(407, 191);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(37, 42);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.Enabled = false;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(407, 251);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(37, 42);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.btnLogin.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(450, 297);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(256, 42);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panelTitleBar.Controls.Add(this.btnLoginExit);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Location = new System.Drawing.Point(321, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(483, 33);
            this.panelTitleBar.TabIndex = 3;
            // 
            // btnLoginExit
            // 
            this.btnLoginExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLoginExit.BackColor = System.Drawing.Color.Transparent;
            this.btnLoginExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLoginExit.FlatAppearance.BorderSize = 0;
            this.btnLoginExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLoginExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginExit.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnLoginExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.btnLoginExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnLoginExit.IconSize = 30;
            this.btnLoginExit.Location = new System.Drawing.Point(455, 1);
            this.btnLoginExit.Name = "btnLoginExit";
            this.btnLoginExit.Size = new System.Drawing.Size(28, 25);
            this.btnLoginExit.TabIndex = 9;
            this.btnLoginExit.UseVisualStyleBackColor = false;
            this.btnLoginExit.Click += new System.EventHandler(this.btnLoginExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(58)))), ((int)(((byte)(47)))));
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 30;
            this.btnMinimize.Location = new System.Drawing.Point(1093, -31);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 25);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(58)))), ((int)(((byte)(47)))));
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 30;
            this.btnMaximize.Location = new System.Drawing.Point(1127, -31);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(28, 25);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(58)))), ((int)(((byte)(47)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 30;
            this.btnExit.Location = new System.Drawing.Point(1161, -31);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 25);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // linklbRegister
            // 
            this.linklbRegister.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linklbRegister.AutoSize = true;
            this.linklbRegister.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.linklbRegister.Location = new System.Drawing.Point(501, 342);
            this.linklbRegister.Name = "linklbRegister";
            this.linklbRegister.Size = new System.Drawing.Size(167, 20);
            this.linklbRegister.TabIndex = 8;
            this.linklbRegister.TabStop = true;
            this.linklbRegister.Text = "Don\'t have account yet?";
            this.linklbRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbRegister_LinkClicked);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(804, 429);
            this.Controls.Add(this.linklbRegister);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private UIControl.CustomTextbox txtEmail;
        private UIControl.CustomTextbox txtPassword;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private UIControl.CustomizeButton btnLogin;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnLoginExit;
        private System.Windows.Forms.LinkLabel linklbRegister;
    }
}