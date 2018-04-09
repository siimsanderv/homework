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

            Console.WriteLine($"Maksimaalne vanus on {maximumage(dates.Min(),today)}\n");

            Console.WriteLine($"Minimaalne vanus on {minimumage(dates.Max(),today)}\n");

            Console.WriteLine($"Keskmine vanus on {averageAge(dates, today)}\n");

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

        public static int averageAge(List<DateTime> dates, DateTime today)
        {
            long totalTicks = 0;
            long averageTicks = 0;
            for (int i = 0; i < dates.Count; i++)
            {
                totalTicks += dates[i].Ticks/1000;
            }
            averageTicks = totalTicks / dates.Count*1000;
            DateTime averageDate = new DateTime(averageTicks);
            int avgAge = today.Year - averageDate.Year;
            if (today < averageDate.AddYears(avgAge))
                avgAge--;
            return avgAge;
        }
    }
}
