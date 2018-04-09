using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<DateTime> dates = new List<DateTime>();
            DateTime today = DateTime.Today;
            List<int> months = new List<int>();
            for (int i = 0; i < 30; i++)
            {
                int year = rnd.Next(1940, 2010);
                int month = rnd.Next(1, 12);
                int day = rnd.Next(1, 31);
                var date = new DateTime(year, month, day);
                dates.Add(date);
                months.Add(month);
            }

            var mostOccurringMonthNr = (from i in months
                        group i by i into grp
                        orderby grp.Count() descending
                        select grp.Key).First();
            string mostOccurringMonth = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mostOccurringMonthNr);
            
            dates.Sort((a, b) => a.CompareTo(b));

            var maximum = dates.Max(record => record.Date);
            
            var minimum = dates.Min(record => record.Date);

            var first = dates.First().Ticks;
            var avg = new DateTime(first + (long)dates.Average(d => d.Ticks - first));

            Console.WriteLine($"Maksimaalne vanus on {maximumage(minimum,today)}\n");

            Console.WriteLine($"Minimaalne vanus on {minimumage(maximum,today)}\n");

            Console.WriteLine($"Keskmine vanus on {averageage(avg, today)}\n");

            Console.WriteLine($"Kõige rohkem sünnipäevi on { mostOccurringMonth} kuus.\n");

            foreach (var stamp in dates)
                Console.WriteLine($"{stamp.ToString("dd/MM/yyyy")} ");

            Console.ReadKey();
            
        }

        public static int minimumage(DateTime maximum, DateTime today)
        {
            int minimumAge = today.Year - maximum.Year;
            if (today < maximum.AddYears(minimumAge))
                minimumAge--;
            return minimumAge;
        }

        public static int maximumage(DateTime minimum, DateTime today)
        {
            int maximumAge = today.Year - minimum.Year;
            if (today < minimum.AddYears(maximumAge))
                maximumAge--;
            return maximumAge;
        }

        public static int averageage(DateTime avg, DateTime today)
        {
            int avgAge = today.Year - avg.Year;
            if (today < avg.AddYears(avgAge))
                avgAge--;
            return avgAge;
        }
    }
}
