using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var randomIndex = random.Next(0, words.Length);
                var randomWord = words[randomIndex];

                words[i] = randomWord;
                words[randomIndex] = currentWord;
               
            }

            foreach (var word in words)
            {

                Console.WriteLine(word);
            }

            

            //var currentWord = words[i];

            //var randomIndex = random.Next(0, words.Length);
            //var randomWord = words[randomIndex];

            //words[i] = randomWord;
            //words[randomIndex] = currentWord;
        }
    }
}
