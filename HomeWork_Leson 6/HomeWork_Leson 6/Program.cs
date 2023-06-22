class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number N of the prime number:");
        int n = Convert.ToInt32(Console.ReadLine());

        int primeNumber = FindNthPrime(n);

        Console.WriteLine($"N-The simple number: {primeNumber}");
    }

    static int FindNthPrime(int n)
    {
        if (n <= 0)
        {
            throw new ArgumentException("The number N must be a positive number.");
        }

        int count = 0;
        int number = 2;

        while (count < n)
        {
            if (IsPrime(number))
            {
                count++;
            }

            number++;
        }

        return number - 1;
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
