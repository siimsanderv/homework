using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnitoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("See programm jätab igas lauses esimese ja viimase tähe paigale, kuid muudab sõna sees olevate tähtede järjekorda.");
            Console.Write("Sisesta lause: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            foreach (string word in words)
            {
                char[] reversedWord = word.ToCharArray();
                int len = reversedWord.Length;
                Random rnd = new Random(); //fisher-yates shuffle https://www.dotnetperls.com/fisher-yates-shuffle
                for (int i=1;i<len;i++) 
                {
                    int r = i + rnd.Next(len - i-1);
                    char t = reversedWord[r];
                    reversedWord[r] = reversedWord[i];
                    reversedWord[i] = t;
                }
                string newWord = new string(reversedWord);
                Console.Write($"{newWord} ");
            }
            Console.ReadKey();

        }
    }
}
