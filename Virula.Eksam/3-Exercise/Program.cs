using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sisesta minimaalne aastaarv: ");
            int minYear = int.Parse(Console.ReadLine());

            Console.Write("Sisesta maksimaalne aastaarv: ");
            int maxYear = int.Parse(Console.ReadLine());

            Console.Write("Sisesta genereeritavate aastaarvude hulk: ");
            int amntOfYears = int.Parse(Console.ReadLine());

            List<int> years = new List<int>();
            Random rnd = new Random();
            for (int i=0; i<amntOfYears;i++)
            {
                int year = rnd.Next(minYear, maxYear);
                int month = rnd.Next(1, 12);
                int day = rnd.Next(1, 31);
                int hour = rnd.Next(0, 23);
                int minute = rnd.Next(0, 59);
                int second = rnd.Next(0, 59);
                DateTime date = new DateTime(year, month, day, hour, minute, second);
                Console.WriteLine(date);
            }
            Console.ReadKey();
        }
    }
}
