using System;
using System.Threading;

class Program
{
    static object lockObject = new object();
    static int currentNumber = 1;
    static int maxNumbers = 10;

    static void Main()
    {
        Thread evenThread = new Thread(PrintEvenNumbers);
        Thread oddThread = new Thread(PrintOddNumbers);

        evenThread.Start();
        oddThread.Start();

        evenThread.Join();
        oddThread.Join();
    }

    static void PrintEvenNumbers()
    {
        while (currentNumber <= maxNumbers)
        {
            lock (lockObject)
            {
                if (currentNumber % 2 == 0)
                {
                    Console.WriteLine($"Even: {currentNumber}");
                    currentNumber++;
                }
            }
        }
    }

    static void PrintOddNumbers()
    {
        while (currentNumber <= maxNumbers)
        {
            lock (lockObject)
            {
                if (currentNumber % 2 != 0)
                {
                    Console.WriteLine($"Odd: {currentNumber}");
                    currentNumber++;
                }
            }
        }
    }
}
