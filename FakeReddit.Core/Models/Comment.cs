namespace FakeReddit.Core.Models
{
    public class Comment
    {
        public string CommentContent { get; set; }
        public int Id { get; set; }
        public virtual int PostId { get; set; }
        public virtual int UserId { get; set; }
    }
}
