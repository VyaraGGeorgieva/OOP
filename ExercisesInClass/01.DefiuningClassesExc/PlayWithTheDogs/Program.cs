using System;

class Program
{
    static void Main()
    {
        //обекти, инстанции на конкретния клас Dog
        Dog unnamed = new Dog(null, "stray");
        Dog sharo = new Dog("Sharo", "German shepherd");

        //unnamed.Breed = "stray";
        unnamed.Bark();
        sharo.Bark();

    }
}

