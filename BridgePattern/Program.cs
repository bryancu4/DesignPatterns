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
            var documents = new List<Manuscript>();
            var formatter = new StandardFormatter();

            var faq = new Faq(formatter);
            faq.Title = "The Bridge Pattern FAQ";
            faq.Questions.Add("What is it?", "A design pattern");
            faq.Questions.Add("When do we use it?", "When you need to seperate an abstraction from an implementation.");
            documents.Add(faq);

            var book = new Book(formatter)
            {
                Title = "Lots of Patterns",
                Author = "John Somez",
                Text = "Blah Blah Blah ..."
            };
            documents.Add(book);

            var paper = new TermPaper(formatter)
            {
                Class = "Design Patterns",
                Student = "Joe Noob",
                Text = "Blah Blah Blah ...",
                References = "GOF"
            };
            documents.Add(paper);

            foreach (var document in documents)
            {
                document.Print();
            }



            Console.ReadKey();
        }
    }
}
