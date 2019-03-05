using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeReddit.Core.Models
{
    public class User
    {
        public User()
        {
            Posts = new List<Post>();
            Comments = new List<Comment>();
        }

        public int CommentCount
        {
            get
            {
                return Comments.Count;
            }
        }

        public virtual ICollection<Comment> Comments { get; set; }

        [Required]
        public string Email { get; set; }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        public int PostCount
        {
            get
            {
                return Posts.Count;
            }
        }

        public virtual ICollection<Post> Posts { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
