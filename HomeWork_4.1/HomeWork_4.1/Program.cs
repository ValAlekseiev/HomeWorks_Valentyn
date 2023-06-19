
        int[] numbers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

        Console.WriteLine("Enter the number to search for:");
        int target = Convert.ToInt32(Console.ReadLine());

        int position = Array.IndexOf(numbers, target);
        if (position != -1)
        {
            Console.WriteLine($"Number {target} found at the position {position} in the array.");
        }
        else
        {
            Console.WriteLine($"Number {target} is not in the array.");
        }
   
