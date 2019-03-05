using FakeReddit.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeReddit.Services.Interfaces
{
    public interface IPostService
    {
        void AddPost(Post post);

        void DeletePost(Post post);

        void EditPost(Post post);

        Post GetPost(int id);

        ICollection<Post> GetPosts();
    }
}
