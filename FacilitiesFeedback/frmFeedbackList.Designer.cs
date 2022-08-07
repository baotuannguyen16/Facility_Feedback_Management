namespace FacilitiesFeedback
{
    partial class frmFeedbackList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFeedback = new System.Windows.Forms.DataGridView();
            this.btnAddFeedback = new FacilitiesFeedback.UIControl.CustomizeButton();
            this.btnDelete = new FacilitiesFeedback.UIControl.CustomizeButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboxFilter = new FacilitiesFeedback.UIControl.FacilitiesFeedback.UIControl.CustomCombobox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFilter = new FacilitiesFeedback.UIControl.CustomizeButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFeedback
            // 
            this.dgvFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFeedback.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFeedback.BackgroundColor = System.Drawing.Color.White;
            this.dgvFeedback.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFeedback.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFeedback.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFeedback.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvFeedback.Location = new System.Drawing.Point(12, 68);
            this.dgvFeedback.Name = "dgvFeedback";
            this.dgvFeedback.RowHeadersVisible = false;
            this.dgvFeedback.RowHeadersWidth = 51;
            this.dgvFeedback.RowTemplate.Height = 29;
            this.dgvFeedback.Size = new System.Drawing.Size(1002, 487);
            this.dgvFeedback.TabIndex = 0;
            this.dgvFeedback.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeedback_CellClick);
            this.dgvFeedback.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeedback_CellDoubleClick);
            // 
            // btnAddFeedback
            // 
            this.btnAddFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(175)))), ((int)(((byte)(71)))));
            this.btnAddFeedback.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(175)))), ((int)(((byte)(71)))));
            this.btnAddFeedback.BorderColor = System.Drawing.Color.Black;
            this.btnAddFeedback.BorderRadius = 10;
            this.btnAddFeedback.BorderSize = 2;
            this.btnAddFeedback.FlatAppearance.BorderSize = 0;
            this.btnAddFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFeedback.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddFeedback.ForeColor = System.Drawing.Color.White;
            this.btnAddFeedback.Location = new System.Drawing.Point(891, 12);
            this.btnAddFeedback.Name = "btnAddFeedback";
            this.btnAddFeedback.Size = new System.Drawing.Size(123, 50);
            this.btnAddFeedback.TabIndex = 8;
            this.btnAddFeedback.Text = "Add New";
            this.btnAddFeedback.TextColor = System.Drawing.Color.White;
            this.btnAddFeedback.UseVisualStyleBackColor = false;
            this.btnAddFeedback.Click += new System.EventHandler(this.btnAddFeedback_Click);
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
            this.btnDelete.TabIndex = 10;
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
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 52);
            this.panel1.TabIndex = 11;
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
            this.label1.Size = new System.Drawing.Size(421, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "* Status: 0 = Processing, 1 = Aproved, 2 = Rejected";
            // 
            // frmFeedbackList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1026, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddFeedback);
            this.Controls.Add(this.dgvFeedback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFeedbackList";
            this.Text = "frmFeedbackList";
            this.Load += new System.EventHandler(this.frmFeedbackList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFeedback;
        private UIControl.CustomizeButton btnAddFeedback;
        private UIControl.CustomizeButton btnDelete;
        private System.Windows.Forms.Panel panel1;
        private UIControl.FacilitiesFeedback.UIControl.CustomCombobox cboxFilter;
        private System.Windows.Forms.Label label2;
        private UIControl.CustomizeButton btnFilter;
        private System.Windows.Forms.Label label1;
    }
}