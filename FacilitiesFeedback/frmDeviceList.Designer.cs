namespace FacilitiesFeedback
{
    partial class frmDeviceList
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
            this.dgvDevice = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboxFilter = new FacilitiesFeedback.UIControl.FacilitiesFeedback.UIControl.CustomCombobox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFilter = new FacilitiesFeedback.UIControl.CustomizeButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDevice
            // 
            this.dgvDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDevice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDevice.BackgroundColor = System.Drawing.Color.White;
            this.dgvDevice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvDevice.Location = new System.Drawing.Point(12, 68);
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.RowHeadersVisible = false;
            this.dgvDevice.RowHeadersWidth = 51;
            this.dgvDevice.RowTemplate.Height = 29;
            this.dgvDevice.Size = new System.Drawing.Size(1002, 487);
            this.dgvDevice.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cboxFilter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 52);
            this.panel1.TabIndex = 9;
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
            this.cboxFilter.Location = new System.Drawing.Point(72, 6);
            this.cboxFilter.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboxFilter.Name = "cboxFilter";
            this.cboxFilter.Padding = new System.Windows.Forms.Padding(3);
            this.cboxFilter.Size = new System.Drawing.Size(250, 38);
            this.cboxFilter.TabIndex = 5;
            this.cboxFilter.Texts = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status";
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
            this.btnFilter.Location = new System.Drawing.Point(328, 5);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(97, 39);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextColor = System.Drawing.Color.White;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "* Status: 0 = Faulty, 1 = Correcting, 2 = Normal";
            // 
            // frmDeviceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1026, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDevice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeviceList";
            this.Text = "frmFeedbackList";
            this.Load += new System.EventHandler(this.frmDeviceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDevice;
        private System.Windows.Forms.Panel panel1;
        private UIControl.CustomizeButton btnFilter;
        private System.Windows.Forms.Label label1;
        private UIControl.FacilitiesFeedback.UIControl.CustomCombobox cboxFilter;
        private System.Windows.Forms.Label label2;
    }
}