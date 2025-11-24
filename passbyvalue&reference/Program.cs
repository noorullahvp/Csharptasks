using System;
using System.ComponentModel;

class Program
{

    static void addanumber( int n)
    {
        n = 100;
    }
    static void Main()
    {
        int a = 10;
        addanumber( a);
        Console.WriteLine(a);
        int s = 20;
        addNumbers2(ref s);
        Console.WriteLine(s);
    }

    static void addNumbers2(ref int s)
    {
        s = 500;
    }

   

}