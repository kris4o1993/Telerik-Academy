namespace DayOfWeekService.Client
{
    using System;
    using DayOfWeekService.Client.DayOfWeekServiceReference;

    public class Program
    {
        public static void Main()
        {
            var client = new DayOfWeekServiceClient();

            var dayOfWeek = client.DayOfWeek(DateTime.Now);
            Console.WriteLine(dayOfWeek);
        }
    }
}
