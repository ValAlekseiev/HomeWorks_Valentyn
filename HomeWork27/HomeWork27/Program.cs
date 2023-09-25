using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        int numberToSquare = 10;
        Task<int> task = CalculateAsync(numberToSquare);

        Console.WriteLine("Task started");

        
        int result = await task;

        Console.WriteLine("Result: " + result);
    }

    static async Task<int> CalculateAsync(int number)
    {
     
        await Task.Delay(1000); 

        return number * number;
    }
}
