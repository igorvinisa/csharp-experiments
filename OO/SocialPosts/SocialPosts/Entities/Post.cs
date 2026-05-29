using System;
using System.Collections.Generic;
using System.Text;

namespace SocialPosts.Entities
{
    public class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine(Title);
            str.Append(Likes);
            str.Append(" Like - ");
            str.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            str.AppendLine(Content);
            str.AppendLine("Comments:");
            
            foreach (Comment comment in Comments)
            {
                str.AppendLine(comment.Text);
            }

            return str.ToString();
        }
    }
}