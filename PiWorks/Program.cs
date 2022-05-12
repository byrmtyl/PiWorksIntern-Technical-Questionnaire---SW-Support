using System;

public class is_divisible_Pi
{
    public static void Main()
    {
        Console.Write("Example Input : ");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);
        int rem = 0, sum = 0, x;
        double output;

        x = number;

        while (number > 0)
        {
            rem = number % 10;
            sum = sum + rem;
            number = number / 10;
        }
        output = x / sum;
        if (x % sum == 0)
            Console.WriteLine("{0} is disible by {1} (result: {2}) |True",x,sum, output);
        else
            Console.WriteLine("{0} is not a disible by {1} (result: {2}) |False", x, sum, output);
    }
}