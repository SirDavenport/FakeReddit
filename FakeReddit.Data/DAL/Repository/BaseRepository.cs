using FakeReddit.Data.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeReddit.Data.DAL.Repository
{
    public abstract class BaseRepository : IBaseRepository
    {
        protected static RedditContext _db;

        public BaseRepository()
        {
            _db = new RedditContext();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
