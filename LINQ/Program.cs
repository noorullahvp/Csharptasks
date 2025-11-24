using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
        string[] names = { "Alice", "bob", "charlie" };

        var evenNumbers = numbers.Where(n => n % 2 == 0);
        var bigger = names.Where(n => n.Length > 5);
        foreach(var name in bigger)
        {
            Console.WriteLine(name);
        }

        foreach(var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
        
    }
}
