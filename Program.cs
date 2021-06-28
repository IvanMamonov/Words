using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordsLine = Console.ReadLine();
            var sb = new StringBuilder();

            foreach (char c in wordsLine)
            {
                if (!char.IsPunctuation(c))
                    sb.Append(c);
            }

            wordsLine = sb.ToString();

            string[] wordsArr = wordsLine.Split(' ');

            foreach (var w in wordsArr)
            {
                if (w[0] == w[w.Length-1])
                {
                    Console.WriteLine(w);
                }
            }
        }
    }
}
