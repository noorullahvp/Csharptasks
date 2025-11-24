using System;
using System.Collections.Immutable;

class Program
{
    static void Array()
    {


    }
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"first number is {numbers[0]}");
        int[] numbersi = new int[] {10,20,30,40,50};
        int[] integers = new int[5];
        integers[0] = 199;
        integers[1] = 400;
        integers[2] = 300;
        integers[3] = 200;
        integers[4] = 000;
        Console.WriteLine($"last number is {integers[4]}");

        for(int i=0; i<numbers.Length;i++)
        {
            Console.WriteLine(numbers[i]);
        }
        for(int i=0; i<integers.Length;i++)
        {
            Console.WriteLine(integers[i]);
        }
        for (int i = 0; i < numbersi.Length;i++)
        {
            Console.WriteLine(numbersi[i]);
        }
        foreach(int num in numbers)
        {
            Console.WriteLine(num);
        }    
        foreach(int suk in integers)
        {
            Console.WriteLine(suk);
        }
        foreach(int numi in numbersi)
        {
            Console.WriteLine(numi);
        }
        {
            Console.WriteLine(numbers.Length);
        }
    }
}
