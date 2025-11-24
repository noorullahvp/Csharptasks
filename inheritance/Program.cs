using System;

class  Animal
{
    public string name;

    public void bite()
    {
        Console.WriteLine($"{name} is bitting");
    }
}

class  Dog:Animal
{
    public void bark()
    {
        Console.WriteLine($"{name} is barking");
    }

    static void Main()
    {
        Dog MyDog = new Dog();
        MyDog.name = "tommy";
        MyDog.bark();
        MyDog.bite();
    }
}