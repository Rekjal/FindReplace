using System;
using FindReplace.Models;
using System.Collections.Generic;

namespace FindReplace
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a sentence:");
            string source = Console.ReadLine();
            Console.WriteLine("Enter FROM string:");
            string from = Console.ReadLine();
            Console.WriteLine("Enter TO string:");
            string to = Console.ReadLine();

            FindR userSentence = new FindR();

            string replacement = userSentence.ConvertSentence(source, from, to);

            Console.WriteLine($"The source string is <{source}>");
            Console.WriteLine($"The updated string is <{replacement}>");
        }
    }
}
