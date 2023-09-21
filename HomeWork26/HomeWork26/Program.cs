using System;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Enumerable.Range(1, 1000000).ToArray();
        int numberOfThreads = Environment.ProcessorCount; 
        long sum = 0;

        if (args.Length > 0 && int.TryParse(args[0], out int userThreadCount) && userThreadCount > 0)
        {
            numberOfThreads = Math.Min(numberOfThreads, userThreadCount);
        }

        Console.WriteLine($"Using {numberOfThreads} threads for parallel calculation.");

        try
        {
            Parallel.For(0, numberOfThreads, threadIndex =>
            {
                long localSum = 0;
                for (int i = threadIndex; i < numbers.Length; i += numberOfThreads)
                {
                    localSum += Calculate(numbers[i]);
                }

                Interlocked.Add(ref sum, localSum);
            });

            Console.WriteLine("Sum: " + sum);
        }
        catch (AggregateException ex)
        {
            foreach (var innerException in ex.InnerExceptions)
            {
                Console.WriteLine($"Error: {innerException.Message}");
            }
        }
    }

    static long Calculate(int number)
    {
        return (long)number * number;
    }
}
