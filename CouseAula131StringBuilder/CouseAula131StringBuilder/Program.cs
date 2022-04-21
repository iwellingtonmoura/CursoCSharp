using System;
using CouseAula131StringBuilder.Entities;

namespace CouseAula131StringBuilder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Comment comment1 = new Comment("Have a nice trip!");
            Comment comment2 = new Comment("Wow that's awesome!");

            Post post1 = new Post(

                DateTime.Parse(DateTime.Now.ToLongDateString()),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country",
                12);


            post1.AddComment(comment1);
            post1.AddComment(comment2);


            Comment comment3 = new Comment("Good Night");
            Comment comment4 = new Comment("May the force be with you");

            Post post2 = new Post(

                DateTime.Parse("28/12/2019 15:00:05"),
                "Good Night Guys",
                "See You Tomorrow",
                5 );


            post2.AddComment(comment3);
            post2.AddComment(comment4);


            Console.WriteLine(post1);
            Console.WriteLine(post2);
        }
    }
}
