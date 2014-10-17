namespace DayOfWeekService
{
    using System;

    public class DayOfWeekService : IDayOfWeekService
    {
        public string DayOfWeek(DateTime date)
        {
            return date.DayOfWeek.ToString();
        }
    }
}
