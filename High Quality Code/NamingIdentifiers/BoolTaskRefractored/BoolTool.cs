namespace BoolTaskRefractored
{
    using System;

    public class BoolTool
    {
        private const int MaxValue = 6;  ////I am using PascalCase because of StyleCop

        public class BoolPrinter
        {
            public void PrintBoolValue(bool value)
            {
                string outputToPrint = value.ToString();
                Console.WriteLine(outputToPrint);
            }
        }
    }
}
