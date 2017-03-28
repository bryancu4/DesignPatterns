using System;

namespace BridgePattern
{
    public class Book : IManuscript
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("Title: {0}", Title);
            Console.WriteLine("Author: {0}", Author);
            Console.WriteLine("Text: {0}", Text);
            Console.WriteLine();
        }
    }
}
