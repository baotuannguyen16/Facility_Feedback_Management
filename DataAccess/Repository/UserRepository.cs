using BusinessObject.Models;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public class UserRepository : IUserRepository
    {
        public void AddUser(User user) => UserDAO.Instance.AddUser(user);
        public void DeleteUser(User user) => UserDAO.Instance.DeleteUser(user);
        public User GetUserById(int id) => UserDAO.Instance.GetUserById(id);
        public IEnumerable<User> GetUsers() => UserDAO.Instance.GetUsers();
        public void UpdateUser(User user) => UserDAO.Instance.UpdateUser(user);
    }
}
