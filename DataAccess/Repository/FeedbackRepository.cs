using BusinessObject.Models;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public class FeedbackRepository : IFeedbackRepository
    {
        public void AddFeedback(Feedback feedback) => FeedbackDAO.Instance.AddFeedback(feedback);

        public void DeleteFeedback(Feedback feedback) => FeedbackDAO.Instance.DeleteFeedback(feedback);

        public IEnumerable<Feedback> GetFeedbacks() => FeedbackDAO.Instance.GetFeedbacks();

        public void UpdateFeedback(Feedback feedback) => FeedbackDAO.Instance.UpdateFeedback(feedback);

        public IEnumerable<Feedback> GetFeedbacksByUserId(int userId) => FeedbackDAO.Instance.GetFeedbacksByUserId(userId);
    }
}
