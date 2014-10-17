namespace ContainsCounterService
{
    public class ContainsCounterService : IContainsCounterService
    {
        public int ContainsCounter(string first, string second)
        {
            var count = 0;
            var index = first.IndexOf(second, System.StringComparison.Ordinal);

            while (index >= 0)
            {
                index = first.IndexOf(second, index + 1, System.StringComparison.Ordinal);
                count++;
            }

            return count;
        }
    }
}
