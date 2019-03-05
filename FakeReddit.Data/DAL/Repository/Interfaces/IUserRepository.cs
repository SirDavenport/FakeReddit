using FakeReddit.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeReddit.Data.DAL.Repository.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(User user);

        void DeleteUser(User user);

        void EditUser(User user);

        User GetUser(int id);

        User GetUserByEmail(string email);

        ICollection<User> GetUsers();
    }
}
