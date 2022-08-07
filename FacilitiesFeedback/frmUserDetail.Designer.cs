namespace FacilitiesFeedback
{
    partial class frmUserDetail
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
            this.txtId = new FacilitiesFeedback.UIControl.CustomTextbox();
            this.txtName = new FacilitiesFeedback.UIControl.CustomTextbox();
            this.txtPhone = new FacilitiesFeedback.UIControl.CustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new FacilitiesFeedback.UIControl.CustomTextbox();
            this.txtEmail = new FacilitiesFeedback.UIControl.CustomTextbox();
            this.lbUserDetail = new System.Windows.Forms.Label();
            this.btnSave = new FacilitiesFeedback.UIControl.CustomizeButton();
            this.customizeButton1 = new FacilitiesFeedback.UIControl.CustomizeButton();
            this.cboxStatus = new FacilitiesFeedback.UIControl.FacilitiesFeedback.UIControl.CustomCombobox();
            this.cboxRole = new FacilitiesFeedback.UIControl.FacilitiesFeedback.UIControl.CustomCombobox();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtId.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtId.BorderSize = 3;
            this.txtId.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtId.Location = new System.Drawing.Point(98, 83);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(7);
            this.txtId.PasswordChar = false;
            this.txtId.Size = new System.Drawing.Size(200, 38);
            this.txtId.TabIndex = 0;
            this.txtId.Texts = "";
            this.txtId.UnderlinedStyle = false;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtName.BorderSize = 3;
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(98, 143);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(7);
            this.txtName.PasswordChar = false;
            this.txtName.Size = new System.Drawing.Size(200, 40);
            this.txtName.TabIndex = 1;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtPhone.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtPhone.BorderSize = 3;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPhone.Location = new System.Drawing.Point(98, 202);
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(7);
            this.txtPhone.PasswordChar = false;
            this.txtPhone.Size = new System.Drawing.Size(200, 40);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.Texts = "";
            this.txtPhone.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(27, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(27, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(348, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(27, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label5.Location = new System.Drawing.Point(27, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(348, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Role";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label7.Location = new System.Drawing.Point(348, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 28);
            this.label7.TabIndex = 9;
            this.label7.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtPassword.BorderSize = 3;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(453, 143);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(218, 40);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtEmail.BorderSize = 3;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(453, 83);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(218, 38);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // lbUserDetail
            // 
            this.lbUserDetail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbUserDetail.AutoSize = true;
            this.lbUserDetail.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUserDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.lbUserDetail.Location = new System.Drawing.Point(220, 9);
            this.lbUserDetail.Name = "lbUserDetail";
            this.lbUserDetail.Size = new System.Drawing.Size(246, 59);
            this.lbUserDetail.TabIndex = 14;
            this.lbUserDetail.Text = "User Detail";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(175)))), ((int)(((byte)(71)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(175)))), ((int)(((byte)(71)))));
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(195, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 38);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Edit";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // customizeButton1
            // 
            this.customizeButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customizeButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(175)))), ((int)(((byte)(71)))));
            this.customizeButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(175)))), ((int)(((byte)(71)))));
            this.customizeButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customizeButton1.BorderRadius = 10;
            this.customizeButton1.BorderSize = 0;
            this.customizeButton1.FlatAppearance.BorderSize = 0;
            this.customizeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizeButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customizeButton1.ForeColor = System.Drawing.Color.White;
            this.customizeButton1.Location = new System.Drawing.Point(371, 325);
            this.customizeButton1.Name = "customizeButton1";
            this.customizeButton1.Size = new System.Drawing.Size(138, 38);
            this.customizeButton1.TabIndex = 16;
            this.customizeButton1.Text = "Cancel";
            this.customizeButton1.TextColor = System.Drawing.Color.White;
            this.customizeButton1.UseVisualStyleBackColor = false;
            this.customizeButton1.Click += new System.EventHandler(this.customizeButton1_Click);
            // 
            // cboxStatus
            // 
            this.cboxStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboxStatus.BackColor = System.Drawing.Color.White;
            this.cboxStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.cboxStatus.BorderSize = 3;
            this.cboxStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboxStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboxStatus.ForeColor = System.Drawing.Color.Black;
            this.cboxStatus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.cboxStatus.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboxStatus.ListTextColor = System.Drawing.Color.DimGray;
            this.cboxStatus.Location = new System.Drawing.Point(98, 260);
            this.cboxStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboxStatus.Name = "cboxStatus";
            this.cboxStatus.Padding = new System.Windows.Forms.Padding(3);
            this.cboxStatus.Size = new System.Drawing.Size(200, 43);
            this.cboxStatus.TabIndex = 17;
            this.cboxStatus.Texts = "";
            // 
            // cboxRole
            // 
            this.cboxRole.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboxRole.BackColor = System.Drawing.Color.White;
            this.cboxRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.cboxRole.BorderSize = 3;
            this.cboxRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cboxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboxRole.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboxRole.ForeColor = System.Drawing.Color.Black;
            this.cboxRole.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.cboxRole.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboxRole.ListTextColor = System.Drawing.Color.DimGray;
            this.cboxRole.Location = new System.Drawing.Point(453, 202);
            this.cboxRole.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboxRole.Name = "cboxRole";
            this.cboxRole.Padding = new System.Windows.Forms.Padding(3);
            this.cboxRole.Size = new System.Drawing.Size(218, 72);
            this.cboxRole.TabIndex = 18;
            this.cboxRole.Texts = "";
            // 
            // frmUserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(695, 374);
            this.Controls.Add(this.cboxRole);
            this.Controls.Add(this.cboxStatus);
            this.Controls.Add(this.customizeButton1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbUserDetail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmUserDetail";
            this.Load += new System.EventHandler(this.frmUserDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIControl.CustomTextbox txtId;
        private UIControl.CustomTextbox txtName;
        private UIControl.CustomTextbox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private UIControl.CustomTextbox txtPassword;
        private UIControl.CustomTextbox txtEmail;
        private System.Windows.Forms.Label lbUserDetail;
        private UIControl.CustomizeButton btnSave;
        private UIControl.CustomizeButton customizeButton1;
        private UIControl.FacilitiesFeedback.UIControl.CustomCombobox cboxStatus;
        private UIControl.FacilitiesFeedback.UIControl.CustomCombobox cboxRole;
    }
}