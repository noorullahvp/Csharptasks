using System;
using System.Collections.Generic;
using System.Linq;

class student
{
    public string name { get; set; }
    public int Mark { get; set; }

}

class program
{
    static void Main()
    {
        var students = new List<student>()
        {
            new student { name ="noor", Mark= 60},
            new student{name ="ameen",Mark=60 },
            new student{name="safa",Mark=90 },
            new student{name="basith",Mark=90 }
        };

        var orderd = students.GroupBy(o => o.Mark);
                             

       foreach(var st in orderd)
        {
            Console.WriteLine($"order name is {st.name} order mark is {st.Mark}");
        }

    }
}