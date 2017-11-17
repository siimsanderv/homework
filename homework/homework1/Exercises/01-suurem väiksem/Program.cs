using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_suurem_väiksem
{
    class Program
    {
        static void Main(string[] args)
        {
            int arv = 27;
            Console.WriteLine("Ma valin välja ühe suvalise arvu vahemikus [1-100]. Proovi see ära arvata");
            Console.Write("Sisesta arv: ");
            int k_arv = int.Parse(Console.ReadLine());
            if (k_arv > arv)
            {
                Console.WriteLine("\nTeie arvatud arv on suurem.");
            }
            if (k_arv < arv)
            {
                Console.WriteLine("\nTeie arvatud arv on väiksem.");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
        }
    }
}
