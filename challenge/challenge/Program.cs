using System;

namespace challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "atalay";
            string word2 = "merhaba";

            string[] words = word1.Split(' ');
            string[] words2 = word2.Split(' ');

            foreach (var item in words)
            {
                Console.WriteLine(item + " ");
            }
           
        }



    }
}
