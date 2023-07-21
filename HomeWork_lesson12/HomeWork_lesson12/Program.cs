using System;
using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        int[] array1 = GenerateRandomArray(10000);
        int[] array2 = (int[])array1.Clone();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        BubbleSort<int>.Sort(array1);
        stopwatch.Stop();
        Console.WriteLine("Using generic types: " + stopwatch.Elapsed);
        stopwatch.Reset();
        stopwatch.Start();
        BubbleSort.Sort(array2);
        stopwatch.Stop();
        Console.WriteLine("Without using generic types: " + stopwatch.Elapsed);
    }

    private static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100);
        }
        return array;
    }
}
