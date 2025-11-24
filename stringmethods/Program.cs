using System;

class Program
{

    static void Main()
    {
        string name = "Muhammed,Noorullah";
        string fullName = " muhammed Noorullah";
        string[] names = name.Split(',');
        bool check = name.Equals(fullName);
        int length = name.Length;
        {
            Console.WriteLine(length);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(fullName.Trim());
            Console.WriteLine(fullName.Contains("Noor"));
            Console.WriteLine(name.Substring(0, 5));
            Console.WriteLine(name.Substring(1, 9));
            Console.WriteLine(name.Substring(5));
            Console.WriteLine(name.Replace("Muhammed", "Safa"));
            Console.WriteLine(string.Join("|",names));
            Console.WriteLine(name.IndexOf("N"));
            Console.WriteLine(name.Remove(4, 6));
            Console.WriteLine(name.Insert(9,"vp"));
            Console.WriteLine(check);

        }
    }
}
