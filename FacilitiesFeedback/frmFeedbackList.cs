using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FacilitiesFeedback
{
    public partial class frmFeedbackList : Form
    {
        IFeedbackRepository feedbackRepository = new FeedbackRepository();
        List<Feedback> feedbackList = new List<Feedback>();
        List<object> list = new List<object>();
        int CurrentRow;
        public User user { get; set; }
        public frmFeedbackList()
        {
            InitializeComponent();
        }

        private void frmFeedbackList_Load(object sender, System.EventArgs e)
        {
            var statusList = new[]
            {
                new { status = "Processing", value = 0},
                new { status = "Aproved", value = 1},
                new { status = "Rejected", value = 2},
            };
            cboxFilter.DataSource = statusList;
            cboxFilter.ValueMember = "value";
            cboxFilter.DisplayMember = "status";
            if (user.Role != 0)
            {
                if (user.Role == 3)
                {
                    btnDelete.Visible = false;
                }
                btnAddFeedback.Visible = false;
                ShowData();
            }
            else
            {
                btnDelete.Visible = false;
                if (user.Status == 1)
                {
                    new frmMessageBox("You are banned! Cannot Create Feedback").ShowDialog();
                    btnAddFeedback.Enabled = false;
                }
                ShowData();
            }

        }

        private List<Feedback> UserFeedbackList(int userId)
        {
            return (List<Feedback>)feedbackRepository.GetFeedbacksByUserId(userId);
        }

        private List<Feedback> StaffFeedbackList(int staffId)
        {
            return (List<Feedback>)feedbackRepository.GetFeedbacks().Where(x => x.StaffId == staffId && x.Status == 0).ToList();
        }

        private List<Feedback> FeedbackList()
        {
            return (List<Feedback>)feedbackRepository.GetFeedbacks();
        }
        private void ShowData()
        {
            if (user.Role == 1 || user.Role == 2)
            {
                feedbackList = FeedbackList();
            }
            else if (user.Role == 3)
            {
                feedbackList = StaffFeedbackList(user.Id);
            }
            else
            {
                feedbackList = UserFeedbackList(user.Id);
            }
            dgvFeedback.DataSource = null;
            dgvFeedback.DataSource = feedbackList;
            dgvFeedback.Columns["Device"].Visible = false;
            dgvFeedback.Columns["Staff"].Visible = false;
            dgvFeedback.Columns["User"].Visible = false;
        }

        private void ShowData(List<Feedback> feedbacks)
        {
            dgvFeedback.DataSource = null;
            dgvFeedback.DataSource = feedbacks;
            dgvFeedback.Columns["Device"].Visible = false;
            dgvFeedback.Columns["Staff"].Visible = false;
            dgvFeedback.Columns["User"].Visible = false;
        }
        private void dgvFeedback_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
            {
                return;
            }
            frmFeedbackDetail frmFeedbackDetail = new frmFeedbackDetail
            {
                feedback = (Feedback)dgvFeedback.Rows[e.RowIndex].DataBoundItem,
                user = user,
            };
            if (frmFeedbackDetail.ShowDialog() == DialogResult.OK)
            {
                ShowData();
                if (user.Role != 3)
                {
                    dgvFeedback.CurrentCell = dgvFeedback.Rows[e.RowIndex].Cells[e.ColumnIndex];
                }
            }
        }

        private void btnAddFeedback_Click(object sender, System.EventArgs e)
        {
            frmCreateFeedback frmCreateFeedback = new frmCreateFeedback
            {
                user = user,
            };
            if (frmCreateFeedback.ShowDialog() == DialogResult.OK)
            {
                ShowData();
            }
        }

        private void dgvFeedback_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrentRow = e.RowIndex;
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            try
            {
                var feedback = (Feedback)dgvFeedback.Rows[CurrentRow].DataBoundItem;

                var Confirm = MessageBox.Show("Are you want to delete this Feedback?", "Confirm Delete!!!", MessageBoxButtons.YesNo);
                if (Confirm == DialogResult.Yes)
                {
                    feedbackRepository.DeleteFeedback(feedback);
                    MessageBox.Show("Delete Successful", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData();
                }
            }
            catch (Exception ex)
            {
                new frmMessageBox(ex.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                var feedbackListFilter = feedbackList.Where(x => x.Status == Int32.Parse(cboxFilter.SelectedValue.ToString())).ToList();
                ShowData(feedbackListFilter);
            }
            catch (Exception ex)
            {
                new frmMessageBox(ex.Message).ShowDialog();
            }
        }
    }
}
