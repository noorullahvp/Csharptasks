using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var even = numbers.Where(n => n % 2 == 0);

        foreach(var n in even)
        {
            Console.WriteLine(n);
        }

    }

}