using System;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start program.");
            var post = new Post();
            post.Title = "Ty";
            post.Description = "Ty cool post";
            post.VoteDown();
            post.VoteDown();

            post.Votes = 1000;
            Console.WriteLine("{0} ({1}) has {2} votes.", post.Title, post.Description, post.Votes);

        }
    }
}
