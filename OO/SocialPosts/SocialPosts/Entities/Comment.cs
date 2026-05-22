using System;
using System.Collections.Generic;
using System.Text;

namespace SocialPosts.Entities
{
    public class Comment
    {
        public string Text { get; set; }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
