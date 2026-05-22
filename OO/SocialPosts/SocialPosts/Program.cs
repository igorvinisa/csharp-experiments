using SocialPosts.Entities;
using System.Globalization;

namespace SocialPosts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post firstPost =
                new Post
                (
                    moment: new DateTime(2018, 06, 21, 13, 05, 44),
                    title: "Traveling to New Zealand",
                    content: "I'm going to visit this wonderful country!",
                    likes: 12
                );

            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("How that's awesome!");

            firstPost.AddComment(c1);
            firstPost.AddComment(c2);

            Post secondPost =
                new Post
                 (
                    moment: new DateTime(2018, 07, 28, 23, 14, 19),
                    title: "Good night guys",
                    content: "See you tomorrow",
                    likes: 5
                );

            c1 = new Comment("Good night");
            c2 = new Comment("May the force be with you");

            secondPost.AddComment(c1);
            secondPost.AddComment(c2);


            List<Post> posts = new List<Post>();

            posts.Add(firstPost);
            posts.Add(secondPost);

            foreach (Post post in posts)
            {
                Console.WriteLine(post.Title);
                Console.WriteLine($"{post.Likes} Likes - { DateTime.SpecifyKind(post.Moment, DateTimeKind.Local) }");
                Console.WriteLine(post.Content);
                Console.WriteLine("Comments:");
                
                foreach (Comment comment in post.Comments)
                    Console.WriteLine(comment.Text);

                Console.WriteLine();
            }
        }
    }
}
