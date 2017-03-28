using System;
using System.Linq;

namespace BridgePattern
{
    public class BackwardBook : Book
    {
        public override void Print()
        {
            Console.WriteLine("Title: {0}", new string(Title.Reverse().ToArray()));
            Console.WriteLine("Author: {0}", new string(Author.Reverse().ToArray()));
            Console.WriteLine("Text: {0}", new string(Text.Reverse().ToArray()));
            Console.WriteLine();
        }
    }
}
