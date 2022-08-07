namespace FacilitiesFeedback
{
    partial class frmCreateUser
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
            this.components = new System.ComponentModel.Container();
            this.deviceDAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRePassword = new FacilitiesFeedback.UIControl.CustomTextbox();
            this.txtPassword = new FacilitiesFeedback.UIControl.CustomTextbox();
            this.txtName = new FacilitiesFeedback.UIControl.CustomTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new FacilitiesFeedback.UIControl.CustomTextbox();
            this.btnCancel = new FacilitiesFeedback.UIControl.CustomizeButton();
            this.btnCreate = new FacilitiesFeedback.UIControl.CustomizeButton();
            this.lbUserDetail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deviceDAOBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceDAOBindingSource
            // 
            this.deviceDAOBindingSource.DataSource = typeof(DataAccess.DeviceDAO);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.txtRePassword);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.lbUserDetail);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 354);
            this.panel1.TabIndex = 0;
            // 
            // txtRePassword
            // 
            this.txtRePassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtRePassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtRePassword.BorderSize = 3;
            this.txtRePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRePassword.Location = new System.Drawing.Point(183, 246);
            this.txtRePassword.Multiline = false;
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtRePassword.PasswordChar = true;
            this.txtRePassword.Size = new System.Drawing.Size(274, 40);
            this.txtRePassword.TabIndex = 63;
            this.txtRePassword.Texts = "";
            this.txtRePassword.UnderlinedStyle = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassword.BorderSize = 3;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(183, 194);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(274, 40);
            this.txtPassword.TabIndex = 62;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            // 
            // txtName
            // 
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtName.BorderSize = 3;
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(183, 137);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(7);
            this.txtName.PasswordChar = false;
            this.txtName.Size = new System.Drawing.Size(274, 40);
            this.txtName.TabIndex = 61;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(49, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 28);
            this.label4.TabIndex = 60;
            this.label4.Text = "Re-password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(49, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 59;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 58;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 28);
            this.label1.TabIndex = 57;
            this.label1.Text = "Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderSize = 3;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(183, 80);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(274, 40);
            this.txtEmail.TabIndex = 56;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(175)))), ((int)(((byte)(71)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(175)))), ((int)(((byte)(71)))));
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(268, 313);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 38);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreate.AutoSize = true;
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(175)))), ((int)(((byte)(71)))));
            this.btnCreate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(175)))), ((int)(((byte)(71)))));
            this.btnCreate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCreate.BorderRadius = 10;
            this.btnCreate.BorderSize = 0;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(84, 313);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(138, 38);
            this.btnCreate.TabIndex = 54;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextColor = System.Drawing.Color.White;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lbUserDetail
            // 
            this.lbUserDetail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbUserDetail.AutoSize = true;
            this.lbUserDetail.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUserDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.lbUserDetail.Location = new System.Drawing.Point(120, 2);
            this.lbUserDetail.Name = "lbUserDetail";
            this.lbUserDetail.Size = new System.Drawing.Size(257, 59);
            this.lbUserDetail.TabIndex = 53;
            this.lbUserDetail.Text = "Create User";
            // 
            // frmCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(531, 378);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCreateFeedback";
            ((System.ComponentModel.ISupportInitialize)(this.deviceDAOBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource deviceDAOBindingSource;
        private System.Windows.Forms.Panel panel1;
        private UIControl.CustomTextbox txtRePassword;
        private UIControl.CustomTextbox txtPassword;
        private UIControl.CustomTextbox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UIControl.CustomTextbox txtEmail;
        private UIControl.CustomizeButton btnCancel;
        private UIControl.CustomizeButton btnCreate;
        private System.Windows.Forms.Label lbUserDetail;
    }
}