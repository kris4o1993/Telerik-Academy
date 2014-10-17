using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

class WorkDays
{
    static void Main()
    {
        Console.WriteLine("Enter a end date in YYYY/MM/DD format");
        string[] endDateStr = Console.ReadLine().Split('/');
        int day = int.Parse(endDateStr[2]);
        int month = int.Parse(endDateStr[1]);
        int year = int.Parse(endDateStr[0]);

        DateTime startDay = DateTime.Today;
        DateTime endDay = new DateTime(year, month, day);
        int timeLen = 0;
        timeLen = Math.Abs((endDay - startDay).Days);
        if (startDay > endDay)
        {
            startDay = endDay;
            endDay = DateTime.Today;
        }

        DateTime[] holidays =
        {
            new DateTime(2014, 1, 1),
            new DateTime(2014, 5, 24),
            new DateTime(2014, 5, 1),
            new DateTime(2014, 12, 24),
            new DateTime(2014, 12, 25),
        };

        Console.WriteLine("Days between today and chosed date: " + timeLen);
        int workDayCounter = 0;
        bool isHoliday = false;

        for (int i = 0; i < timeLen; i++)
        {
            startDay = startDay.AddDays(1);
            if (startDay.DayOfWeek != DayOfWeek.Sunday && startDay.DayOfWeek != DayOfWeek.Saturday)
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (startDay == holidays[j])
                    {
                        isHoliday = true;
                        break;
                    }
                }

                if (!isHoliday)
                {
                    workDayCounter++;
                }

                isHoliday = false;
            }
        }

        Console.WriteLine("Workdays: " + workDayCounter);
    }
}
