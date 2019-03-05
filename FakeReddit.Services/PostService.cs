using FakeReddit.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeReddit.Core.Models;
using FakeReddit.Data.DAL.Repository;

namespace FakeReddit.Services
{
    public class PostService : IPostService
    {
        private PostRepository _postRepository;

        public PostService()
        {
            _postRepository = new PostRepository();
        }

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
            return _postRepository.GetPost(id);
        }

        public ICollection<Post> GetPosts()
        {
            return _postRepository.GetPosts();
        }
    }
}
