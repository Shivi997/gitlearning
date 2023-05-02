using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringEncoder();
            
        }

        private static void StringEncoder()
        {
            Console.WriteLine("Enter the string ");
            string input = Console.ReadLine();



            string[] words = input.Split(' ');



            string encoded = "";
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (char.IsLetter(c))
                {
                    int wordIndex = Array.FindIndex(words, word => word.Contains(c.ToString()));
                    int letterIndex = Array.IndexOf(words[wordIndex].ToCharArray(), c) + 1;
                    string code = $"{wordIndex + 1}{letterIndex}";
                    Console.WriteLine($" {code}");

                }
            }
        }
    }
}
    

