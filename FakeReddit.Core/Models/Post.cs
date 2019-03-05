using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FakeReddit.Core.Models
{
    public class Post
    {
        public Post()
        {
            Comments = new List<Comment>();
            Date = DateTime.Now;
        }

        public virtual ICollection<Comment> Comments { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public int Id { get; set; }
        public string Subject { get; set; }
        public virtual int? UserId { get; set; }
    }
}
