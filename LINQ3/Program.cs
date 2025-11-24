using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 5, 10, 2, 4, 1, 8, 6 };

        var OrderOn = numbers.OrderByDescending(s => s);

       foreach(var ord in OrderOn)
        {
            Console.WriteLine(ord);
        }
        var ordeIt = numbers.OrderBy(n => n);

        foreach(var number in ordeIt)
        {
            Console.WriteLine(number);
        }
    }
}