using System;

class Program
{
    static void Main()
    {
        string[] names = { "noorulah", "safa", "midhu" }; 
        List<int> marks = new List<int>();

        marks.Add(50);
        marks.Add(60);
        marks.Add(70);
        marks.Add(80);
        marks.Add(90);

        var upper = names.Select(n => n.ToUpper());
        foreach (var nmup in upper)
        {
            Console.WriteLine(nmup);
        }

        var doubles = marks.Select(n => n * 2);

        foreach (var num in doubles)
        {
            Console.WriteLine(num);
        }
    }
}