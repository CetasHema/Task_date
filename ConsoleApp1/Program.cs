using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var date = DateTime.Now;
            var date1 = $"{date:d}";
            Console.WriteLine(date.ToString("dd"));
            Console.WriteLine(date.ToString("MM"));
            Console.WriteLine(date.ToString("yyyy"));
            var wk = DateTime.Today.DayOfWeek;
            Console.WriteLine(wk);
            
            //Add Days
            Console.WriteLine("Enter the number of days to add :");
            int days = Convert.ToInt32(Console.ReadLine());
            DateTime newDated = date.AddDays(days);
            Console.WriteLine("Date after "+ days+" days :"+newDated.ToShortDateString());
            
            //Add weeks
            Console.WriteLine("Enter the number of weeks to add :");
            int weeks = Convert.ToInt32(Console.ReadLine());
            DateTime newDatew = date.AddDays(weeks*7);
            Console.WriteLine("Date after " + days + " days :" + newDatew.ToShortDateString());
            
            //Add months
            Console.WriteLine("Enter the number of months to add :");
            int months = Convert.ToInt32(Console.ReadLine());
            DateTime newDatem = date.AddMonths(months);
            Console.WriteLine(newDatem.ToShortDateString());

            //Add Years
            Console.WriteLine("Enter the number of years to add :");
            int years = Convert.ToInt32(Console.ReadLine());
            DateTime newDatey = date.AddYears(years);
            Console.WriteLine(newDatey.ToShortDateString());

        }
    }
}
