using System;
using System.Linq;
using Animals.Animals;
using Animals.Animals.Cats;

namespace Animals
{
    class Tests
    {
        static void Main()
        {
            var animals = new Animal[]
            {
                new Kitten("Matza",4, Gender.Female),
                new Dog("Sharo", 7, Gender.Male),
                new Kitten("Dzhaki", 6, Gender.Female),
                new Dog("Dzjaf", 6, Gender.Male),
                new TomCat("Myr", 3, Gender.Male),
                new Frog("Qwa", 56, Gender.Female),
                new Frog("Qwa-Qwa", 45, Gender.Female),
                new TomCat("Myr-myr", 2, Gender.Male)
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                Console.WriteLine(animal.ProduceSound());
            }
            // var catsAverageAge = animals.Where(x => x is Cat).Average(x => x.Age);
            //Console.WriteLine("The average age of all cats is: {0}", catsAverageAge);
            Console.WriteLine();
            var catsAverageAge =
                animals.Where(x => x is Cat).Average(x => x.Age);
            Console.WriteLine("The average age of all cats is {0} years.", catsAverageAge);

            var tomCatAvrgAge =
                animals.Where(x => x is TomCat).Average(x => x.Age);
            Console.WriteLine("The average age of all TomCats is {0} years.", tomCatAvrgAge);

            var kittenAvgAge =
                animals.Where(x => x is Kitten).Average(x => x.Age);
            Console.WriteLine("The average age of all kittens is {0} years.", kittenAvgAge);

            var dogAvgAge =
                animals.Where(x => x is Dog).Average(x => x.Age);
            Console.WriteLine("The average age of all dogs is {0} years.", dogAvgAge);

            var frogAvgAge =
                animals.Where(x => x is Frog).Average(x => x.Age);
            Console.WriteLine("The averag age of all frogs is {0} years.", frogAvgAge);
        }
    }
}
