using FakeReddit.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeReddit.Data.DAL.Repository.Interfaces
{
    public interface ICommentRepository
    {
        void AddComment(Comment comment);

        void DeleteComment(Comment comment);

        void EditComment(Comment comment);

        Comment GetComment(int id);

        ICollection<Comment> GetComments();
    }
}
