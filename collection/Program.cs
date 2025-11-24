using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> friends = new List<String> { "Noorullah", "safa", "basith" };
        foreach (string friend in friends)
        {
            Console.WriteLine(friend);
        }
        List<int> marks = new List<int>();
        int[] other = { 70,80,40};
        marks.Add(90);
        marks.Add(95);
        marks.Add(85);
        marks.AddRange(other);
        marks.Insert(2, 30);
        marks.Remove(95);
        marks.RemoveAt(2);
        bool check = marks.Contains(30);

        foreach(int mark in marks)
        Console.WriteLine(mark);
        Console.WriteLine(check);

        Dictionary<int, string> students = new Dictionary<int, string>();
        students.Add(101, "NOORULLAH");
        students.Add(102, "safa");
        students.Add(204, "basith");
        
         foreach(KeyValuePair<int,string> student in students)
        {
            Console.WriteLine($"id:{student.Key},Name:{student.Value}");
        }
        
    }
    
}