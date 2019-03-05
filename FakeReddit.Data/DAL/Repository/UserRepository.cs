using FakeReddit.Data.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeReddit.Core.Models;

namespace FakeReddit.Data.DAL.Repository
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public void AddUser(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public void EditUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            return _db.Users.Where(u => u.Id == id).SingleOrDefault();
        }

        public User GetUserByEmail(string email)
        {
            return _db.Users.Where(u => u.Email == email).SingleOrDefault();
        }

        public ICollection<User> GetUsers()
        {
            return _db.Users.ToList();
        }
    }
}
