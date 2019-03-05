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
    public class CommentService : ICommentService
    {
        private CommentRepository _commentRepository;

        public CommentService()
        {
            _commentRepository = new CommentRepository();
        }

        public void AddComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void EditComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Comment GetComment(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Comment> GetComments()
        {
            throw new NotImplementedException();
        }
    }
}
