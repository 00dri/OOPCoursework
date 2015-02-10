namespace _03.Animals
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            var animals = new Animal[] {
            new Dog("Sharo", 3, Gender.Male),
            new Frog("Kermit", 5, Gender.Male),
            new TomCat("Tom", 2),
            new Kitten("Kote", 4)
            };

            var cats = new Cat[]
            {
            new Kitten("Kote", 4),
            new TomCat("Tom", 2)
            };

            Console.WriteLine("# Animals");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("# Produce sound");
            foreach (ISound animal in animals)
            {
                animal.ProduceSound();
            }

            Console.WriteLine("# Average");
            Console.WriteLine(animals.Average(animal => animal.Age));
            Console.WriteLine(cats.Average(cat => cat.Age));
        }
    }
}
