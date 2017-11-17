using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PrintGreeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mitu nime");
            int amt = int.Parse(Console.ReadLine());
            string[] names = new string[amt];
            for (int i = 0; i < amt; i++)
            {
                Console.Write("Sisesta nimi: ");
               names[i] = Console.ReadLine();
            }
            foreach (var name in names)
            {
                PrintGreeting(name);
            }
            Console.ReadKey();
        }
        static void PrintGreeting(string str)
        {
            Console.WriteLine(str);
        }
    }
}
