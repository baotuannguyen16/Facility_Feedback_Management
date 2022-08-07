using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class FeedbackDAO
    {
        //Singleton 
        private static FeedbackDAO instance;
        public static readonly object instanceLock = new object();
        private FeedbackDAO() { }
        public static FeedbackDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new FeedbackDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Feedback> GetFeedbacks()
        {
            List<Feedback> Feedbacks;

            try
            {
                using (var context = new FeedbackDBContext())
                {
                    Feedbacks = context.Feedbacks.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Feedbacks;
        }

        public void AddFeedback(Feedback feedback)
        {
            try
            {
                using (var context = new FeedbackDBContext())
                {
                    if (context.Feedbacks.SingleOrDefault(value => value.Id == feedback.Id) != null)
                    {
                        throw new Exception("This Id was existed");
                    }
                    context.Feedbacks.Add(feedback);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateFeedback(Feedback feedback)
        {
            try
            {
                using (var context = new FeedbackDBContext())
                {
                    context.Entry<Feedback>(feedback).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteFeedback(Feedback feedback)
        {
            try
            {
                using (var context = new FeedbackDBContext())
                {
                    var _feedback = context.Feedbacks.SingleOrDefault(value => value.Id == feedback.Id);
                    context.Feedbacks.Remove(_feedback);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Feedback> GetFeedbacksByUserId(int userId)
        {
            List<Feedback> feedbackList = GetFeedbacks();
            List<Feedback> userFeedbackList = feedbackList.Where(x => x.UserId == userId).ToList();
            return userFeedbackList;
        }
    }
}
