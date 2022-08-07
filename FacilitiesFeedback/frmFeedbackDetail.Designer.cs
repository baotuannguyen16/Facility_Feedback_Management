namespace FacilitiesFeedback
{
    partial class frmFeedbackDetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboxDeviceStatus = new FacilitiesFeedback.UIControl.FacilitiesFeedback.UIControl.CustomCombobox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRoom = new FacilitiesFeedback.UIControl.CustomTextbox();
            this.txtUserName = new FacilitiesFeedback.UIControl.CustomTextbox();
            this.txtDeviceName = new FacilitiesFeedback.UIControl.CustomTextbox();
            this.cboxStaff = new FacilitiesFeedback.UIControl.FacilitiesFeedback.UIControl.CustomCombobox();
            this.txtReply = new FacilitiesFeedback.UIControl.CustomTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxStatus = new FacilitiesFeedback.UIControl.FacilitiesFeedback.UIControl.CustomCombobox();
            this.customizeButton1 = new FacilitiesFeedback.UIControl.CustomizeButton();
            this.btnSave = new FacilitiesFeedback.UIControl.CustomizeButton();
            this.lbUserDetail = new System.Windows.Forms.Label();
            this.txtContent = new FacilitiesFeedback.UIControl.CustomTextbox();
            this.txtDeviceId = new FacilitiesFeedback.UIControl.CustomTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserId = new FacilitiesFeedback.UIControl.CustomTextbox();
            this.txtCreatedDate = new FacilitiesFeedback.UIControl.CustomTextbox();
            this.txtId = new FacilitiesFeedback.UIControl.CustomTextbox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.cboxDeviceStatus);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtRoom);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.txtDeviceName);
            this.panel1.Controls.Add(this.cboxStaff);
            this.panel1.Controls.Add(this.txtReply);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cboxStatus);
            this.panel1.Controls.Add(this.customizeButton1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lbUserDetail);
            this.panel1.Controls.Add(this.txtContent);
            this.panel1.Controls.Add(this.txtDeviceId);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUserId);
            this.panel1.Controls.Add(this.txtCreatedDate);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 515);
            this.panel1.TabIndex = 32;
            // 
            // cboxDeviceStatus
            // 
            this.cboxDeviceStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboxDeviceStatus.BackColor = System.Drawing.Color.White;
            this.cboxDeviceStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.cboxDeviceStatus.BorderSize = 3;
            this.cboxDeviceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboxDeviceStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboxDeviceStatus.ForeColor = System.Drawing.Color.Black;
            this.cboxDeviceStatus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.cboxDeviceStatus.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboxDeviceStatus.ListTextColor = System.Drawing.Color.DimGray;
            this.cboxDeviceStatus.Location = new System.Drawing.Point(854, 188);
            this.cboxDeviceStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboxDeviceStatus.Name = "cboxDeviceStatus";
            this.cboxDeviceStatus.Padding = new System.Windows.Forms.Padding(3);
            this.cboxDeviceStatus.Size = new System.Drawing.Size(200, 40);
            this.cboxDeviceStatus.TabIndex = 61;
            this.cboxDeviceStatus.Texts = "";
            this.cboxDeviceStatus.OnSelectedIndexChanged += new System.EventHandler(this.cboxDeviceStatus_OnSelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label14.Location = new System.Drawing.Point(854, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 28);
            this.label14.TabIndex = 60;
            this.label14.Text = "Status";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label13.Location = new System.Drawing.Point(595, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 28);
            this.label13.TabIndex = 58;
            this.label13.Text = "Name";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label12.Location = new System.Drawing.Point(522, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 28);
            this.label12.TabIndex = 57;
            this.label12.Text = "Id";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label11.Location = new System.Drawing.Point(595, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 28);
            this.label11.TabIndex = 56;
            this.label11.Text = "Name";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label10.Location = new System.Drawing.Point(522, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 28);
            this.label10.TabIndex = 55;
            this.label10.Text = "Id";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label9.Location = new System.Drawing.Point(738, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 28);
            this.label9.TabIndex = 54;
            this.label9.Text = "Room";
            // 
            // txtRoom
            // 
            this.txtRoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtRoom.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtRoom.BorderSize = 3;
            this.txtRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRoom.Location = new System.Drawing.Point(738, 188);
            this.txtRoom.Multiline = false;
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Padding = new System.Windows.Forms.Padding(7);
            this.txtRoom.PasswordChar = false;
            this.txtRoom.Size = new System.Drawing.Size(110, 40);
            this.txtRoom.TabIndex = 53;
            this.txtRoom.Texts = "";
            this.txtRoom.UnderlinedStyle = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtUserName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtUserName.BorderSize = 3;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUserName.Location = new System.Drawing.Point(595, 109);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Padding = new System.Windows.Forms.Padding(7);
            this.txtUserName.PasswordChar = false;
            this.txtUserName.Size = new System.Drawing.Size(110, 38);
            this.txtUserName.TabIndex = 52;
            this.txtUserName.Texts = "";
            this.txtUserName.UnderlinedStyle = false;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDeviceName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtDeviceName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtDeviceName.BorderSize = 3;
            this.txtDeviceName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDeviceName.Location = new System.Drawing.Point(595, 188);
            this.txtDeviceName.Multiline = false;
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Padding = new System.Windows.Forms.Padding(7);
            this.txtDeviceName.PasswordChar = false;
            this.txtDeviceName.Size = new System.Drawing.Size(137, 40);
            this.txtDeviceName.TabIndex = 51;
            this.txtDeviceName.Texts = "";
            this.txtDeviceName.UnderlinedStyle = false;
            // 
            // cboxStaff
            // 
            this.cboxStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboxStaff.BackColor = System.Drawing.Color.White;
            this.cboxStaff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.cboxStaff.BorderSize = 3;
            this.cboxStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboxStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboxStaff.ForeColor = System.Drawing.Color.Black;
            this.cboxStaff.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.cboxStaff.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboxStaff.ListTextColor = System.Drawing.Color.DimGray;
            this.cboxStaff.Location = new System.Drawing.Point(522, 258);
            this.cboxStaff.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboxStaff.Name = "cboxStaff";
            this.cboxStaff.Padding = new System.Windows.Forms.Padding(3);
            this.cboxStaff.Size = new System.Drawing.Size(293, 43);
            this.cboxStaff.TabIndex = 50;
            this.cboxStaff.Texts = "";
            // 
            // txtReply
            // 
            this.txtReply.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtReply.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtReply.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtReply.BorderSize = 3;
            this.txtReply.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtReply.Location = new System.Drawing.Point(586, 340);
            this.txtReply.Multiline = true;
            this.txtReply.Name = "txtReply";
            this.txtReply.Padding = new System.Windows.Forms.Padding(7);
            this.txtReply.PasswordChar = false;
            this.txtReply.Size = new System.Drawing.Size(367, 112);
            this.txtReply.TabIndex = 49;
            this.txtReply.Texts = "";
            this.txtReply.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label8.Location = new System.Drawing.Point(515, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 28);
            this.label8.TabIndex = 48;
            this.label8.Text = "Reply";
            // 
            // cboxStatus
            // 
            this.cboxStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboxStatus.BackColor = System.Drawing.Color.White;
            this.cboxStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.cboxStatus.BorderSize = 3;
            this.cboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboxStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboxStatus.ForeColor = System.Drawing.Color.Black;
            this.cboxStatus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.cboxStatus.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboxStatus.ListTextColor = System.Drawing.Color.DimGray;
            this.cboxStatus.Location = new System.Drawing.Point(207, 197);
            this.cboxStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboxStatus.Name = "cboxStatus";
            this.cboxStatus.Padding = new System.Windows.Forms.Padding(3);
            this.cboxStatus.Size = new System.Drawing.Size(200, 43);
            this.cboxStatus.TabIndex = 47;
            this.cboxStatus.Texts = "";
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
            this.customizeButton1.Location = new System.Drawing.Point(561, 465);
            this.customizeButton1.Name = "customizeButton1";
            this.customizeButton1.Size = new System.Drawing.Size(138, 38);
            this.customizeButton1.TabIndex = 46;
            this.customizeButton1.Text = "Cancel";
            this.customizeButton1.TextColor = System.Drawing.Color.White;
            this.customizeButton1.UseVisualStyleBackColor = false;
            this.customizeButton1.Click += new System.EventHandler(this.customizeButton1_Click);
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
            this.btnSave.Location = new System.Drawing.Point(377, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 38);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Edit";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbUserDetail
            // 
            this.lbUserDetail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbUserDetail.AutoSize = true;
            this.lbUserDetail.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUserDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.lbUserDetail.Location = new System.Drawing.Point(353, 3);
            this.lbUserDetail.Name = "lbUserDetail";
            this.lbUserDetail.Size = new System.Drawing.Size(346, 59);
            this.lbUserDetail.TabIndex = 44;
            this.lbUserDetail.Text = "Feedback Detail";
            // 
            // txtContent
            // 
            this.txtContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtContent.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtContent.BorderSize = 3;
            this.txtContent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtContent.Location = new System.Drawing.Point(130, 340);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Padding = new System.Windows.Forms.Padding(7);
            this.txtContent.PasswordChar = false;
            this.txtContent.Size = new System.Drawing.Size(367, 112);
            this.txtContent.TabIndex = 43;
            this.txtContent.Texts = "";
            this.txtContent.UnderlinedStyle = false;
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDeviceId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtDeviceId.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtDeviceId.BorderSize = 3;
            this.txtDeviceId.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDeviceId.Location = new System.Drawing.Point(522, 188);
            this.txtDeviceId.Multiline = false;
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Padding = new System.Windows.Forms.Padding(7);
            this.txtDeviceId.PasswordChar = false;
            this.txtDeviceId.Size = new System.Drawing.Size(67, 40);
            this.txtDeviceId.TabIndex = 42;
            this.txtDeviceId.Texts = "";
            this.txtDeviceId.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label7.Location = new System.Drawing.Point(37, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 28);
            this.label7.TabIndex = 41;
            this.label7.Text = "Content";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(440, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 28);
            this.label6.TabIndex = 40;
            this.label6.Text = "Staff";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label5.Location = new System.Drawing.Point(102, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 28);
            this.label5.TabIndex = 39;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(440, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 28);
            this.label4.TabIndex = 38;
            this.label4.Text = "User";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(440, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 37;
            this.label3.Text = "Device";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(65, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 28);
            this.label2.TabIndex = 36;
            this.label2.Text = "Created Date";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(102, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 28);
            this.label1.TabIndex = 35;
            this.label1.Text = "Id";
            // 
            // txtUserId
            // 
            this.txtUserId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUserId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtUserId.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtUserId.BorderSize = 3;
            this.txtUserId.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUserId.Location = new System.Drawing.Point(522, 109);
            this.txtUserId.Multiline = true;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Padding = new System.Windows.Forms.Padding(7);
            this.txtUserId.PasswordChar = false;
            this.txtUserId.Size = new System.Drawing.Size(67, 38);
            this.txtUserId.TabIndex = 34;
            this.txtUserId.Texts = "";
            this.txtUserId.UnderlinedStyle = false;
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCreatedDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtCreatedDate.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtCreatedDate.BorderSize = 3;
            this.txtCreatedDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCreatedDate.Location = new System.Drawing.Point(207, 153);
            this.txtCreatedDate.Multiline = true;
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.Padding = new System.Windows.Forms.Padding(7);
            this.txtCreatedDate.PasswordChar = false;
            this.txtCreatedDate.Size = new System.Drawing.Size(200, 38);
            this.txtCreatedDate.TabIndex = 33;
            this.txtCreatedDate.Texts = "";
            this.txtCreatedDate.UnderlinedStyle = false;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtId.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtId.BorderSize = 3;
            this.txtId.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtId.Location = new System.Drawing.Point(207, 109);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(7);
            this.txtId.PasswordChar = false;
            this.txtId.Size = new System.Drawing.Size(200, 38);
            this.txtId.TabIndex = 32;
            this.txtId.Texts = "";
            this.txtId.UnderlinedStyle = false;
            // 
            // frmFeedbackDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1088, 539);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFeedbackDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmUserDetail";
            this.Load += new System.EventHandler(this.frmFeedbackDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private UIControl.CustomTextbox txtRoom;
        private UIControl.CustomTextbox txtUserName;
        private UIControl.CustomTextbox txtDeviceName;
        private UIControl.FacilitiesFeedback.UIControl.CustomCombobox cboxStaff;
        private UIControl.CustomTextbox txtReply;
        private System.Windows.Forms.Label label8;
        private UIControl.FacilitiesFeedback.UIControl.CustomCombobox cboxStatus;
        private UIControl.CustomizeButton customizeButton1;
        private UIControl.CustomizeButton btnSave;
        private System.Windows.Forms.Label lbUserDetail;
        private UIControl.CustomTextbox txtContent;
        private UIControl.CustomTextbox txtDeviceId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UIControl.CustomTextbox txtUserId;
        private UIControl.CustomTextbox txtCreatedDate;
        private UIControl.CustomTextbox txtId;
        private UIControl.FacilitiesFeedback.UIControl.CustomCombobox cboxDeviceStatus;
    }
}