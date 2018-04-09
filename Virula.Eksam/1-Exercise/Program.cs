using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programm küsib inimeste nimesid kuni sisestada '-1'.");
            List<string> names = new List<string>();
            while (true)
            {
                Console.Write("Sisesta nimi:");
                string name = Console.ReadLine();
                if (name == "-1")
                {
                string namelist = string.Join(", ", names.ToArray());
                Console.WriteLine($"Teie sisestatud nimed: {namelist}");
                break;
                }
                else
                names.Add(UpperCaseFirst(name));
            }
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
