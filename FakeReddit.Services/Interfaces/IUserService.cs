using FakeReddit.Core.Models;
using System.Collections.Generic;

namespace FakeReddit.Services.Interfaces
{
    public interface IUserService
    {
        void AddUser(User user);

        void DeleteUser(User user);

        void EditUser(User user);

        User GetUser(int id);

        User GetUserByEmail(string email);

        ICollection<User> GetUsers();
    }
}
