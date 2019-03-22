using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that, given two strings, test whether one is an anagram of the other.");
            Console.WriteLine("First String: ");
            var firstString = Console.ReadLine();
            Console.WriteLine("Second String: ");
            var secondString = Console.ReadLine();
            var message = string.Empty;
            if (validate(firstString, secondString, out message))
                Console.Write(message);
            else
            {               
                if (IsAnagram(firstString, secondString))
                    Console.WriteLine("It's Anagram");
                else
                    Console.WriteLine("It Isn't Anagram");
            }
            Console.ReadLine();
        }

        private static bool validate(string str1, string str2, out string message)
        {
            message = string.Empty;
            if (string.IsNullOrWhiteSpace(str1))
                message += "First string could not be null or white spaces\n";
            if (string.IsNullOrWhiteSpace(str2))
                message += "Second string could not be null or white spaces";
            return (message != string.Empty);
        }

        public static bool IsAnagram(string firstString, string secondString)
        {
            var first = String.Concat(firstString.ToLower().OrderBy(letter => letter));
            var second = String.Concat(secondString.ToLower().OrderBy(letter => letter));
            return first == second;
        }
    }
}
