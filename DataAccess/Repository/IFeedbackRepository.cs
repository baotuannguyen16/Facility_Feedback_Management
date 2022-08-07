using BusinessObject.Models;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public interface IFeedbackRepository
    {
        public IEnumerable<Feedback> GetFeedbacks();
        public void AddFeedback(Feedback feedback);
        public void UpdateFeedback(Feedback feedback);
        public void DeleteFeedback(Feedback feedback);
        public IEnumerable<Feedback> GetFeedbacksByUserId(int id);
    }
}
