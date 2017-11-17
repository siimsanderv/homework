using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int arv = rnd.Next(1, 100);
            Console.WriteLine("Ma valin välja ühe suvalise arvu vahemikus [1 – 100]. Proovi see ära arvata");
            Console.Write("Sisestage arv: ");
            int k_arv = int.Parse(Console.ReadLine());
            while (k_arv != arv)
            {
                if (k_arv > arv)
                {
                    Console.WriteLine("\nTeie valitud arv on suurem!");
                    Console.Write("Proovige uuesti: ");
                }
                else if (k_arv < arv)
                {
                    Console.WriteLine("\nTeie valitud arv on väiksem!");
                    Console.Write("Proovige uuesti: ");
                }
                k_arv = int.Parse(Console.ReadLine());
            }
            if (k_arv == arv)
            {
                Console.WriteLine("\nArvasite arvu õigesti!");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();

        }
    }
}
