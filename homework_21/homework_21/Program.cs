using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Creating a collection of integers
        List<int> numbers = new List<int> { 1, 4, 7, 2, 9, 5, 8, 3, 6 };

        // Using LINQ to perform operations on the collection
        // Examples of operations:

        // 1. Filtering: Select all numbers greater than 4.
        var filteredNumbers = numbers.Where(x => x > 4);

        // 2. Sorting: Sort the numbers in ascending order.
        var sortedNumbers = numbers.OrderBy(x => x);

        // 3. Searching: Check if the number 7 exists in the collection.
        bool containsSeven = numbers.Contains(7);

        // 4. Grouping: Group numbers by the remainder when divided by 2 (even and odd).
        var groupedNumbers = numbers.GroupBy(x => x % 2 == 0 ? "Even" : "Odd");

        // Displaying the results on the screen
        Console.WriteLine("All numbers: " + string.Join(", ", numbers));
        Console.WriteLine("Filtered numbers (>4): " + string.Join(", ", filteredNumbers));
        Console.WriteLine("Sorted numbers: " + string.Join(", ", sortedNumbers));
        Console.WriteLine("Number 7 exists in the collection: " + containsSeven);

        Console.WriteLine("Grouping by remainder when divided by 2:");
        foreach (var group in groupedNumbers)
        {
            Console.WriteLine($"{group.Key}: {string.Join(", ", group)}");
        }
    }
}
