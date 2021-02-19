using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            
            DateTime date = DateTime.Now;
            Console.WriteLine("Curent date and time:" + date);
            var date1 = $"{date:d}";
            Console.WriteLine(date.ToString("dd"));
            Console.WriteLine(date.ToString("MM"));
            Console.WriteLine(date.ToString("yyyy"));
            var wk = DateTime.Today.DayOfWeek;
            Console.WriteLine(wk);
            
            //Add Days
            Console.WriteLine("\nEnter the number of days to add :");
            int days = Convert.ToInt32(Console.ReadLine());
            DateTime newDated = date.AddDays(days);
            Console.WriteLine("Date after "+ days+" days :"+newDated.ToShortDateString());
            
            //Add weeks
            Console.WriteLine("\nEnter the number of weeks to add :");
            int weeks = Convert.ToInt32(Console.ReadLine());
            DateTime newDatew = date.AddDays(weeks*7);
            Console.WriteLine("Date after " + days + " days :" + newDatew.ToShortDateString());
            
            //Add months
            Console.WriteLine("\nEnter the number of months to add :");
            int months = Convert.ToInt32(Console.ReadLine());
            DateTime newDatem = date.AddMonths(months);
            Console.WriteLine(newDatem.ToShortDateString());

            //Add Years
            Console.WriteLine("\nEnter the number of years to add :");
            int years = Convert.ToInt32(Console.ReadLine());
            DateTime newDatey = date.AddYears(years);
            Console.WriteLine(newDatey.ToShortDateString());

            //Add Time
            Console.WriteLine("\n\n......Adding time......");

            Console.WriteLine("\nEnter the number of hours to add :");
            int hr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of minutes to add :");
            int mnt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of seconds to add :");
            int sec = Convert.ToInt32(Console.ReadLine());
            TimeSpan ts = new TimeSpan(hr,mnt,sec);
            DateTime dt1 = date.Add(ts);
            Console.WriteLine("\nCurent date and time:" + date);
            Console.WriteLine("Date after adding time:" + dt1);





        }
    }
}
