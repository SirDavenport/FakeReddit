using FakeReddit.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeReddit.Data.DAL
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<RedditContext>
    {
        protected override void Seed(RedditContext context)
        {
            var comments = new List<Comment>
            {
               new Comment()
               {
                   CommentContent = "Glad to hear it!"
               },
               new Comment()
               {
                   CommentContent = "Thanks, brother."
               }
            };
            var posts = new List<Post>
            {
                new Post()
                {
                    Subject = "Friendly Dog",
                    Content = "There was a friendly dog named Bruno and he was the best puppy around.",
                },
                new Post()
                {
                    Subject = "I love my dog",
                    Content = "My Dog is the greatest thing that happened to me.",
                    Comments = new List<Comment>()
                    {
                        comments[0],
                        comments[1]
                    }
                }
            };
            var users = new List<User>
            {
                new User()
                {
                    Name = "Derek Merkle",
                    Email = "dmerkle@catalyte.io",
                    Password = "12345",
                    Role = "USER",
                    Posts = new List<Post>
                    {
                        posts[0],
                        posts[1]
                    },
                    Comments = new List<Comment>
                    {
                        comments[1]
                    }
                },
                new User()
                {
                    Name = "John Stamos",
                    Email = "johnny@fullhouse.com",
                    Password = "12345",
                    Role = "USER",
                    Comments = new List<Comment>
                    {
                        comments[0]
                    }
                }
            };
            comments.ForEach(c => context.Comments.Add(c));
            posts.ForEach(p => context.Posts.Add(p));
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();
        }
    }
}
