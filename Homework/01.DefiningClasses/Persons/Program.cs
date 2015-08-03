//Define a class Person that has name, age and email. The name and age are mandatory. The email is optional. Define properties that accept non-empty name and age in the range [1 ... 100]. In case of invalid arguments, throw an exception. Define a property for the email that accepts either null or non-empty string containing '@'. Define two constructors. The first constructor should take name, age and email. The second constructor should take name and age only and call the first constructor. Implement the ToString() method to enable printing persons at the console.//
using System;
namespace Persons
{
    class Program
    {
        static void Main()
        {
            Person peter = new Person("Peter", 32, "peter.petrov@gmail.com"); //създаден обект peter от тип Person
            Console.WriteLine(peter); //за да се отпечата, първо се ползва ToString
            Person mario = new Person("Mario", 10);
            Console.WriteLine(mario);
            Person marina = new Person("", -2, "");
            Console.WriteLine(marina);
        }
    }
}
