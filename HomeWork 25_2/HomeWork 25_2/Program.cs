using System;
using System.Threading;

class Program
{
    static object lockA = new object();
    static object lockB = new object();
    static object lockC = new object();
    static int maxIterations = 5;

    static void Main()
    {
        Thread threadA = new Thread(PrintA);
        Thread threadB = new Thread(PrintB);
        Thread threadC = new Thread(PrintC);

        threadA.Start();
        threadB.Start();
        threadC.Start();

        threadA.Join();
        threadB.Join();
        threadC.Join();
    }

    static void PrintA()
    {
        for (int i = 0; i < maxIterations; i++)
        {
            lock (lockA)
            {
                Console.WriteLine("A");
            }
            Thread.Sleep(100); 
        }
    }

    static void PrintB()
    {
        for (int i = 0; i < maxIterations; i++)
        {
            lock (lockA)
            {
                lock (lockB)
                {
                    Console.WriteLine("B");
                }
            }
            Thread.Sleep(100); 
        }
    }

    static void PrintC()
    {
        for (int i = 0; i < maxIterations; i++)
        {
            lock (lockB)
            {
                lock (lockC)
                {
                    Console.WriteLine("C");
                }
            }
            Thread.Sleep(100); 
        }
    }
}
