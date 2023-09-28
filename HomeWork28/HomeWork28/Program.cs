using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int arraySize = 100000000;
        int[] numbers = Enumerable.Range(1, arraySize).ToArray();


        int numberOfThreads = Environment.ProcessorCount;

        if (args.Length > 0 && int.TryParse(args[0], out int userThreadCount) && userThreadCount > 0)
        {
            numberOfThreads = Math.Min(numberOfThreads, userThreadCount);
        }

        Console.WriteLine($"Using {numberOfThreads} threads for PLINQ processing.");

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        var result = numbers.AsParallel()
                            .WithDegreeOfParallelism(numberOfThreads)
                            .Where(x => x % 2 == 0)
                            .Select(x => x * x)
                            .ToList();

        stopwatch.Stop();

        Console.WriteLine("Result count: " + result.Count);
        Console.WriteLine("Time taken: " + stopwatch.ElapsedMilliseconds + "ms");
    }
}
