using FakeReddit.Data.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeReddit.Core.Models;

namespace FakeReddit.Data.DAL.Repository
{
    public class PostRepository : BaseRepository, IPostRepository
    {
        public void AddPost(Post post)
        {
            throw new NotImplementedException();
        }

        public void DeletePost(Post post)
        {
            throw new NotImplementedException();
        }

        public void EditPost(Post post)
        {
            throw new NotImplementedException();
        }

        public Post GetPost(int id)
        {
            return _db.Posts.Where(p => p.Id == id).SingleOrDefault();
        }

        public ICollection<Post> GetPosts()
        {
            return _db.Posts.ToList();
        }
    }
}
