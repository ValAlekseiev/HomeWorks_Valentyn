using System;
using System.Collections.Generic;

public class LargeNumber
{
    private List<int> digits;

    public LargeNumber(string number)
    {
        digits = new List<int>();
        foreach (char digitChar in number)
        {
            if (char.IsDigit(digitChar))
            {
                digits.Add(int.Parse(digitChar.ToString()));
            }
            else
            {
                throw new ArgumentException("Invalid character in number: " + digitChar);
            }
        }
    }

    public LargeNumber(List<int> digits)
    {
        this.digits = digits;
    }

    public LargeNumber Add(LargeNumber other)
    {
        List<int> resultDigits = new List<int>();
        int carry = 0;
        int maxLength = Math.Max(digits.Count, other.digits.Count);

        for (int i = 0; i < maxLength; i++)
        {
            int sum = carry;
            if (i < digits.Count)
            {
                sum += digits[digits.Count - 1 - i];
            }
            if (i < other.digits.Count)
            {
                sum += other.digits[other.digits.Count - 1 - i];
            }

            resultDigits.Insert(0, sum % 10);
            carry = sum / 10;
        }

        if (carry > 0)
        {
            resultDigits.Insert(0, carry);
        }

        return new LargeNumber(resultDigits);
    }

    // Implement Subtract method similarly

    public override string ToString()
    {
        return string.Join("", digits);
    }

    public static void Main(string[] args)
    {
        LargeNumber num1 = new LargeNumber("123456789012345678901234567890");
        LargeNumber num2 = new LargeNumber("987654321098765432109876543210");

        LargeNumber sum = num1.Add(num2);
        Console.WriteLine("Sum: " + sum);
    }
}
