using FakeReddit.Data.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeReddit.Core.Models;

namespace FakeReddit.Data.DAL.Repository
{
    public class CommentRepository : BaseRepository, ICommentRepository
    {
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
