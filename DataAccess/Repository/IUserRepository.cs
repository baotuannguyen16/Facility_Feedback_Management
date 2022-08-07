using BusinessObject.Models;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetUsers();
        public void AddUser(User user);
        public void UpdateUser(User user);
        public void DeleteUser(User user);
        public User GetUserById(int id);
    }
}
