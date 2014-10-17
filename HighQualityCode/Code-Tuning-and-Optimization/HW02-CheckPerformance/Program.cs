namespace HW02_CheckPerformance
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    public class Program
    {
        public static void DisplayExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        public static void Main()
        {
            Addition.AdditionOfIntegers(3242334, 4234211);
            Addition.AdditionOfLongs(43534521234, 5345255345);
            Addition.AdditionOfFloats(4.323432f, 84234.233f);
            Addition.AdditionOfDoubles(4.34234, 24.43245356565624);
            Addition.AdditionOfDecimals(325434534.4523443453345345m, 3489272.46234275345m);
            Console.WriteLine("-------------------------------------------");
            Substraction.SubstractionOfIntegers(3242334, 4234211);
            Substraction.SubstractionOfLongs(43534521234, 5345255345);
            Substraction.SubstractionOfFloats(4.323432f, 84234.233f);
            Substraction.SubstractionOfDoubles(4.34234, 24.43245356565624);
            Substraction.SubstractionOfDecimals(325434534.4523443453345345m, 3489272.46234275345m);
            Console.WriteLine("-------------------------------------------");
            Multiplication.MultiplicationOfIntegers(3242334, 4234211);
            Multiplication.MultiplicationOfLongs(43534521234, 5345255345);
            Multiplication.MultiplicationOfFloats(4.323432f, 84234.233f);
            Multiplication.MultiplicationOfDoubles(4.34234, 24.43245356565624);
            Multiplication.MultiplicationOfDecimals(325434534.4523443453345345m, 3489272.46234275345m);
            Console.WriteLine("-------------------------------------------");
            Division.DivisionOfIntegers(3242334, 4234211);
            Division.DivisionOfLongs(43534521234, 5345255345);
            Division.DivisionOfFloats(4.323432f, 84234.233f);
            Division.DivisionOfDoubles(4.34234, 24.43245356565624);
            Division.DivisionOfDecimals(325434534.4523443453345345m, 3489272.46234275345m);
            Console.WriteLine("-------------------------------------------");
            SquareRoot.SqrtOfFloats(4.323432f);
            SquareRoot.SqrtOfDoubles(24.43245356565624);
            SquareRoot.SqrtOfDecimals(325434534.4523443453345345m);
            Console.WriteLine("-------------------------------------------");
            NaturalLog.LogOfFloats(4.323432f);
            NaturalLog.LogOfDoubles(24.43245356565624);
            NaturalLog.LogOfDecimals(325434534.4523443453345345m);
            Console.WriteLine("-------------------------------------------");
            Sinus.SinOfFloats(4.323432f);
            Sinus.SinOfDoubles(24.43245356565624);
            Sinus.SinOfDecimals(325434534.4523443453345345m);
        }
    }
}