
        int[] numbers = { 1, 2, 3, 4, 5, 6 };

        Console.WriteLine("The initial array of numbers:");
        PrintArray(numbers);

        ReverseArray(numbers);

        Console.WriteLine("An array of numbers after reflection:");
        PrintArray(numbers);
    

    static void ReverseArray(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {

            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            left++;
            right--;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

