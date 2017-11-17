using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tunnikontroll17._11
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Text.Encoding utf_8 = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string eur = "€";
            byte[] utf = System.Text.Encoding.UTF8.GetBytes(eur);
            Console.WriteLine("Taco Palenque\n1200 Main ST.");
            Console.WriteLine("----------------------------------------");
            double sum = 0;
            while (true)
            {
                Console.Write("Enter price of food item [-1 to quit]: ");
                var input = Console.ReadLine();
                if (input == "-1")
                    break;
                double dblInput = double.Parse(input);
                sum = sum + dblInput;
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Subtotal: {eur}{sum.ToString("F")}");
            double graduity = sum * 0.15;
            Console.WriteLine($"15.00 % Gratuity: {eur}{graduity.ToString("F")}");
            double total = sum - graduity;
            Console.WriteLine($"Total: {eur}{total.ToString("F")}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
