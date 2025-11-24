using System;
using System.Collections.Generic;
using System.Linq;

class   Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 4, 6, 7, 8, 8, 9, 10 };

        var df = numbers.First(n => n > 5);
        
       
        {
            Console.WriteLine(df);
        }
    }
}