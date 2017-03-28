using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var faq = new Faq();
            faq.Title = "The Bridge Pattern FAQ";
            faq.Questions.Add("What is it?", "A design pattern");
            faq.Questions.Add("When do we use it?", "When you need to seperate an abstraction from an implementation.");
            faq.Print();

            var book = new Book
            {
                Title = "Lots of Patterns",
                Author = "John Somez",
                Text = "Blah Blah Blah ..."
            };
            book.Print();

            var paper = new TermPaper
            {
                Class = "Design Patterns",
                Student = "Joe Noob",
                Text = "Blah Blah Blah ...",
                References = "GOF"
            };
            paper.Print();

            Console.ReadKey();
        }
    }
}
