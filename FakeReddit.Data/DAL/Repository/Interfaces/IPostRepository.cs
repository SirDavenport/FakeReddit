﻿using FakeReddit.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeReddit.Data.DAL.Repository.Interfaces
{
    public interface IPostRepository
    {
        void AddPost(Post post);

        void DeletePost(Post post);

        void EditPost(Post post);

        Post GetPost(int id);

        ICollection<Post> GetPosts();
    }
}
