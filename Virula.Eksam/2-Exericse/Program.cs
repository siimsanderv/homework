using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Exericse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>(new string[] { "kaur", "mattias", "kristel", "heleri", "trevor", "kristjan", "kelli", "kevin", "maarika", "laura" });
            Console.Write("Sisestage lause: ");
            string sentence = Console.ReadLine();
            List<string> sentence_list = sentence.Split(' ').ToList();
            for(int i=0;i<names.Count();i++)
            {
                for(int j=0;j<sentence_list.Count();j++)
                {
                    if (sentence_list[j].Contains(names[i]))
                    {
                        sentence_list[j] = UpperCaseFirst(sentence_list[j]);
                    }
                }
            }
            string fixedSentence = string.Join(" ", sentence_list.ToArray());
            Console.WriteLine($"Parandatud lause: {fixedSentence}");
            Console.ReadKey();

        }
        static string UpperCaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;
            else
                return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
