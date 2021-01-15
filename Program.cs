using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfExample
{
    class DateTimeExtensions
    {
        public string ToAgeString(DateTime dob)
        {
            DateTime dt = DateTime.Now;

            int days = dt.Day - dob.Day;
            if (days < 0)
            {
                dt = dt.AddMonths(-1);
                days += DateTime.DaysInMonth(dt.Year, dt.Month);
            }

            int months = dt.Month - dob.Month;
            if (months < 0)
            {
                dt = dt.AddYears(-1);
                months += 12;
            }

            int years = dt.Year - dob.Year;

            return string.Format("{0} year{1}, {2} month{3} and {4} day{5}",
                                 years, (years == 1) ? "" : "s",
                                 months, (months == 1) ? "" : "s",
                                 days, (days == 1) ? "" : "s");
        }

        static void Main()
        {
            Console.Write("enter your name:");
            string name = Console.ReadLine().ToString();
            DateTimeExtensions obj = new DateTimeExtensions();
            Console.Write("Enter the Birth of year : ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter the Birth of month : ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter the Birth day: ");
            int day = int.Parse(Console.ReadLine());
            string s = month + "/" + day + "/" + year;
            DateTime dob = DateTime.Parse(s);
            string s2 = obj.ToAgeString(dob);
            Console.WriteLine("Hi {0} you are {1}", name, s2);
            Console.ReadLine();
        }
    }
}