using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_random
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
            if (arv == k_arv)
            {   
                Console.WriteLine($"\nMinu valitud arv: {arv}");
                Console.WriteLine("Te valisite õige arvu!");
            }
            else if (arv > k_arv)
            {
                Console.WriteLine($"\nMinu valitud arv: {arv}");
                Console.WriteLine("Teie valitud arv on väiksem!");
            }
            else if (arv < k_arv)
            {
                Console.WriteLine($"\nMinu valitud arv: {arv}");
                Console.WriteLine("Teie valitud arv on suurem!");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
        }
    }
}
