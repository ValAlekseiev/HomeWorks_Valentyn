using System;
using System.Data;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an arithmetic expression: ");
            string expression = Console.ReadLine();

            try
            {
                double result = Calculate(expression);
                Console.WriteLine($"result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }
        }

        static double Calculate(string expression)
        {
            DataTable dt = new DataTable();
            return Convert.ToDouble(dt.Compute(expression, ""));
        }
    }
}
