using abstraction;
using System;



 abstract class vehicle
{
      public abstract void Start();
      public string name;
    
}

class engine:Interface1
{
    public void stop()
    {
        Console.WriteLine("engine stoped");
    }
}

class car : vehicle
{
    public override void Start()
    {
        Console.WriteLine($"{name}car started");
    }
}
 class Program
{
        public static void Main()
    {
        car myCar = new car();
        myCar.name = "swift";
        myCar.Start();
        engine myEngine = new engine();
        myEngine.stop();
    }

}
