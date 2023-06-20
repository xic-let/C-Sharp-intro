using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criar e instanciar o objecto no codigo. 
           Posts posts = new Posts(DateTime.Parse("21/10/2023 13:10:02"), "Traveling to new Zealand", "I'm goingto visit this wonderfull Country!", 12);
           // inserir comentarios

            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("wowww that's awesome!");
            //Adicionar os comentários na lista
            posts.AddComment(c1);
            posts.AddComment(c2);

            Posts posts2 = new Posts(DateTime.Parse("16/05/2023 14:34:02"), "Here we go!", "Let'scode!", 25);
            // inserir comentarios

            Comment c3 = new Comment("Good luck!");
            Comment c4 = new Comment("All work, no play :P !");
            //Adicionar os comentários na lista
            posts2.AddComment(c3);
            posts2.AddComment(c4);

            Console.WriteLine(posts);
            Console.WriteLine(posts2);
        }
    }
}