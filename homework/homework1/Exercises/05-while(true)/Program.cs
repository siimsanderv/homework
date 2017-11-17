using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_while_true_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int arv = rnd.Next(1, 100);
            Console.WriteLine("Ma valin välja ühe suvalise arvu vahemikus [1 – 100]. Proovi see ära arvata");
            Console.Write("Sisestage arv: ");
            while (true)
            {
                int k_arv = int.Parse(Console.ReadLine());
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
                else if (k_arv == arv)
                {
                    Console.WriteLine("\nTeie valitud arv on õige!");
                    break;
                }
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
        }
    }
}
