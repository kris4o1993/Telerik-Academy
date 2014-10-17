namespace Task09_PrintSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// We are given the following sequence:
    /// S1 = N;
    /// S2 = S1 + 1;
    /// S3 = 2*S1 + 1;
    /// S4 = S1 + 2;
    /// S5 = S2 + 1;
    /// S6 = 2*S2 + 1;
    /// S7 = S2 + 2;
    /// ...
    /// Using the Queue<T> class write a program to print its first 50 members for given N.
    /// Example: N=2 -> 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
    /// </summary>
    public class Program
    {
        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            var sequence = Sequence(n);

            foreach (var item in sequence)
            {
                Console.WriteLine(item);
            }
        }

        static List<int> Sequence(int n)
        {
            var queue = new Queue<int>();
            var sequence = new List<int>();

            queue.Enqueue(n);

            while (queue.Count < 50)
            {
                int current = queue.Dequeue();
                sequence.Add(current);

                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current + 1);
                queue.Enqueue(current + 2);
            }

            while (sequence.Count < 50)
            {
                sequence.Add(queue.Dequeue());
            }

            return sequence;
        }
    }
}
