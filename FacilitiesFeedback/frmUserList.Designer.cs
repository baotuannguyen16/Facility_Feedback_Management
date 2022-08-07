namespace FacilitiesFeedback
{
    partial class frmUserList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new FacilitiesFeedback.UIControl.CustomizeButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboxFilter = new FacilitiesFeedback.UIControl.FacilitiesFeedback.UIControl.CustomCombobox();
            this.cboxFilterContent = new FacilitiesFeedback.UIControl.FacilitiesFeedback.UIControl.CustomCombobox();
            this.btnFilter = new FacilitiesFeedback.UIControl.CustomizeButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUser.Location = new System.Drawing.Point(12, 68);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 29;
            this.dgvUser.Size = new System.Drawing.Size(1002, 469);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            this.dgvUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(742, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "* Status: 0 = Active, 1 = Inactive \r\n* Role: 0 = User, 1 = Administrator\'s Manage" +
    "r, 2 = Administrator\'s Staff, 3 = Engineer Staff";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.BackgroundColor = System.Drawing.Color.Brown;
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.BorderRadius = 4;
            this.btnDelete.BorderSize = 2;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(917, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 39);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cboxFilter);
            this.panel1.Controls.Add(this.cboxFilterContent);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 52);
            this.panel1.TabIndex = 12;
            // 
            // cboxFilter
            // 
            this.cboxFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboxFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.cboxFilter.BorderSize = 3;
            this.cboxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboxFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxFilter.ForeColor = System.Drawing.Color.Black;
            this.cboxFilter.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.cboxFilter.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboxFilter.ListTextColor = System.Drawing.Color.DimGray;
            this.cboxFilter.Location = new System.Drawing.Point(3, 6);
            this.cboxFilter.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboxFilter.Name = "cboxFilter";
            this.cboxFilter.Padding = new System.Windows.Forms.Padding(3);
            this.cboxFilter.Size = new System.Drawing.Size(200, 38);
            this.cboxFilter.TabIndex = 6;
            this.cboxFilter.Texts = "";
            this.cboxFilter.OnSelectedIndexChanged += new System.EventHandler(this.cboxFilter_OnSelectedIndexChanged);
            // 
            // cboxFilterContent
            // 
            this.cboxFilterContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboxFilterContent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.cboxFilterContent.BorderSize = 3;
            this.cboxFilterContent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboxFilterContent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxFilterContent.ForeColor = System.Drawing.Color.Black;
            this.cboxFilterContent.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.cboxFilterContent.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboxFilterContent.ListTextColor = System.Drawing.Color.DimGray;
            this.cboxFilterContent.Location = new System.Drawing.Point(209, 6);
            this.cboxFilterContent.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboxFilterContent.Name = "cboxFilterContent";
            this.cboxFilterContent.Padding = new System.Windows.Forms.Padding(3);
            this.cboxFilterContent.Size = new System.Drawing.Size(224, 38);
            this.cboxFilterContent.TabIndex = 5;
            this.cboxFilterContent.Texts = "";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(175)))), ((int)(((byte)(71)))));
            this.btnFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(175)))), ((int)(((byte)(71)))));
            this.btnFilter.BorderColor = System.Drawing.Color.Black;
            this.btnFilter.BorderRadius = 10;
            this.btnFilter.BorderSize = 2;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(439, 5);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(97, 39);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextColor = System.Drawing.Color.White;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // frmUserList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1026, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserList";
            this.Text = "frmMemberList";
            this.Load += new System.EventHandler(this.frmUserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label label1;
        private UIControl.CustomizeButton btnDelete;
        private System.Windows.Forms.Panel panel1;
        private UIControl.FacilitiesFeedback.UIControl.CustomCombobox cboxFilterContent;
        private UIControl.CustomizeButton btnFilter;
        private UIControl.FacilitiesFeedback.UIControl.CustomCombobox cboxFilter;
    }
}