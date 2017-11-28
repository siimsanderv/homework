using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_PrintGreeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Siim";
            PrintGreeting(name);
        }
        static void PrintGreeting(string str)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine(str);
            Console.ReadKey();
        }

    }
}
