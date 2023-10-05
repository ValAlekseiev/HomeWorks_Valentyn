using System;

class MyObject
{
    public void Run()
    {
        Console.Write("Enter the number of strings: ");
        int numStrings = int.Parse(Console.ReadLine());

        string[] strings = new string[numStrings];
        for (int i = 0; i < numStrings; i++)
        {
            Console.Write($"Enter string #{i + 1}: ");
            strings[i] = Console.ReadLine();
        }

        MyOtherObject otherObj = new MyOtherObject(strings);

        otherObj.Dispose();
    }
}

class MyOtherObject : IDisposable
{
    private string[] data;

    public MyOtherObject(string[] strings)
    {
        data = strings;
    }

    public void Dispose()
    {
        Console.WriteLine($"Number of strings: {data.Length}");
        Console.WriteLine("Strings:");
        foreach (string str in data)
        {
            Console.WriteLine(str);
        }

        
        GC.Collect();
        GC.WaitForPendingFinalizers();

        
        Console.WriteLine("MyOtherObject was disposed.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyObject obj = new MyObject();
        obj.Run();
    }
}
