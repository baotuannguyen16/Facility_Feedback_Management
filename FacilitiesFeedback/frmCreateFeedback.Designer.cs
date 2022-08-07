namespace FacilitiesFeedback
{
    partial class frmCreateFeedback
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
            this.btnCancel = new FacilitiesFeedback.UIControl.CustomizeButton();
            this.btnCreate = new FacilitiesFeedback.UIControl.CustomizeButton();
            this.lbUserDetail = new System.Windows.Forms.Label();
            this.txtContent = new FacilitiesFeedback.UIControl.CustomTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.deviceDAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboxRoom = new FacilitiesFeedback.UIControl.FacilitiesFeedback.UIControl.CustomCombobox();
            this.cboxDeviceName = new FacilitiesFeedback.UIControl.FacilitiesFeedback.UIControl.CustomCombobox();
            ((System.ComponentModel.ISupportInitialize)(this.deviceDAOBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.btnCancel.Location = new System.Drawing.Point(296, 460);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 38);
            this.btnCancel.TabIndex = 44;
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
            this.btnCreate.Location = new System.Drawing.Point(112, 460);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(138, 38);
            this.btnCreate.TabIndex = 43;
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
            this.lbUserDetail.Location = new System.Drawing.Point(96, 9);
            this.lbUserDetail.Name = "lbUserDetail";
            this.lbUserDetail.Size = new System.Drawing.Size(357, 59);
            this.lbUserDetail.TabIndex = 42;
            this.lbUserDetail.Text = "Create Feedback";
            // 
            // txtContent
            // 
            this.txtContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtContent.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.txtContent.BorderSize = 3;
            this.txtContent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtContent.Location = new System.Drawing.Point(12, 314);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Padding = new System.Windows.Forms.Padding(7);
            this.txtContent.PasswordChar = false;
            this.txtContent.Size = new System.Drawing.Size(505, 112);
            this.txtContent.TabIndex = 41;
            this.txtContent.Texts = "";
            this.txtContent.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label7.Location = new System.Drawing.Point(12, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 38);
            this.label7.TabIndex = 39;
            this.label7.Text = "Content";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 38);
            this.label3.TabIndex = 35;
            this.label3.Text = "Device";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label9.Location = new System.Drawing.Point(112, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 28);
            this.label9.TabIndex = 52;
            this.label9.Text = "Room";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label13.Location = new System.Drawing.Point(111, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 28);
            this.label13.TabIndex = 56;
            this.label13.Text = "Name";
            // 
            // deviceDAOBindingSource
            // 
            this.deviceDAOBindingSource.DataSource = typeof(DataAccess.DeviceDAO);
            // 
            // cboxRoom
            // 
            this.cboxRoom.BackColor = System.Drawing.Color.White;
            this.cboxRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.cboxRoom.BorderSize = 3;
            this.cboxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboxRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboxRoom.ForeColor = System.Drawing.Color.Black;
            this.cboxRoom.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.cboxRoom.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboxRoom.ListTextColor = System.Drawing.Color.DimGray;
            this.cboxRoom.Location = new System.Drawing.Point(198, 153);
            this.cboxRoom.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboxRoom.Name = "cboxRoom";
            this.cboxRoom.Padding = new System.Windows.Forms.Padding(3);
            this.cboxRoom.Size = new System.Drawing.Size(200, 43);
            this.cboxRoom.TabIndex = 59;
            this.cboxRoom.Texts = "";
            this.cboxRoom.OnSelectedIndexChanged += new System.EventHandler(this.cboxRoom_OnSelectedIndexChanged);
            // 
            // cboxDeviceName
            // 
            this.cboxDeviceName.BackColor = System.Drawing.Color.White;
            this.cboxDeviceName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.cboxDeviceName.BorderSize = 3;
            this.cboxDeviceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboxDeviceName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboxDeviceName.ForeColor = System.Drawing.Color.Black;
            this.cboxDeviceName.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.cboxDeviceName.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboxDeviceName.ListTextColor = System.Drawing.Color.DimGray;
            this.cboxDeviceName.Location = new System.Drawing.Point(198, 202);
            this.cboxDeviceName.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboxDeviceName.Name = "cboxDeviceName";
            this.cboxDeviceName.Padding = new System.Windows.Forms.Padding(3);
            this.cboxDeviceName.Size = new System.Drawing.Size(200, 43);
            this.cboxDeviceName.TabIndex = 60;
            this.cboxDeviceName.Texts = "";
            // 
            // frmCreateFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(529, 513);
            this.Controls.Add(this.cboxDeviceName);
            this.Controls.Add(this.cboxRoom);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lbUserDetail);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreateFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCreateFeedback";
            this.Load += new System.EventHandler(this.frmCreateFeedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deviceDAOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIControl.CustomizeButton btnCancel;
        private UIControl.CustomizeButton btnCreate;
        private System.Windows.Forms.Label lbUserDetail;
        private UIControl.CustomTextbox txtContent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource deviceDAOBindingSource;
        private UIControl.FacilitiesFeedback.UIControl.CustomCombobox cboxRoom;
        private UIControl.FacilitiesFeedback.UIControl.CustomCombobox cboxDeviceName;
    }
}