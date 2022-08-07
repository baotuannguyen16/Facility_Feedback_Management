using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class UserDAO
    {
        //Singleton 
        private static UserDAO instance;
        public static readonly object instanceLock = new object();
        private UserDAO() { }
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }

        public List<User> GetUsers()
        {
            List<User> Users;

            try
            {
                using (var context = new FeedbackDBContext())
                {
                    Users = context.Users.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Users;
        }

        public void AddUser(User user)
        {
            try
            {
                using (var context = new FeedbackDBContext())
                {
                    if (context.Users.SingleOrDefault(value => value.Id == user.Id) != null)
                    {
                        throw new Exception("This Id was existed");
                    }
                    context.Users.Add(user);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                using (var context = new FeedbackDBContext())
                {
                    context.Entry<User>(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteUser(User user)
        {
            try
            {
                using (var context = new FeedbackDBContext())
                {
                    var _user = context.Users.SingleOrDefault(value => value.Id == user.Id);
                    context.Users.Remove(_user);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public User GetUserById(int id)
        {
            List<User> userList = GetUsers();
            User user = userList.SingleOrDefault(value => value.Id == id);
            return user;
        }

    }
}
