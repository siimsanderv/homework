using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_võrdne
{
    class Program
    {
        static void Main(string[] args)
        {
            int arv = 28;
            Console.WriteLine("Ma valin välja ühe suvalise arvu vahemikus [1 – 100]. Proovi see ära arvata");
            Console.Write("Sisestage arv: ");
            int k_arv = int.Parse(Console.ReadLine());
            if (k_arv == arv)
            {
                Console.WriteLine("\nTe valisite õige arvu!");
            }
            else if (k_arv > arv)
            {
                Console.WriteLine("\nTeie valitud arv on suurem!");
            }
            else if (k_arv < arv)
            {
                Console.WriteLine("\nTeie valitud arv on väiksem!");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
        }
    }
}
