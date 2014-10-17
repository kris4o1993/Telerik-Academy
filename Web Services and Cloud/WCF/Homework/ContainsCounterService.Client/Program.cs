namespace ContainsCounterService.Client
{
    using System;
    using ContainsCounterService.Client.ContainsCounterServiceReference;

    public class Program
    {
        public static void Main()
        {
            var client = new ContainsCounterServiceClient();

            var count = client.ContainsCounter("haha", "ha");
            Console.WriteLine(count);

            // Proxy class generator (Run it in VS Command Prompt)
            // svcutil /t:code http://localhost:32651/ContainsCounterService.svc /out:D:\MyServiceProxy.cs /config:D:\MyServiceProxy.config
        }
    }
}
