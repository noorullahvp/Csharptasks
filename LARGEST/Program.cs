using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 5, 6, 7, 8 };
        var orde = numbers.OrderByDescending(n => n)
                          .Skip(1).First();
                          
        {
            Console.WriteLine(orde);
        }

    }
}