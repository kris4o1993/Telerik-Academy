namespace Animals
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        private static void Main()
        {
            List<Dog> dogs = new List<Dog>
            {
                new Dog("Cesar", 5, "Male"),
                new Dog("Sharo", 9, "Male")
            };

            List<Frog> frogs = new List<Frog>
            {
                new Frog("Maya Manolova", 4, "Female"),
                new Frog("Petar Chobanov", 2, "Male")
            };

            List<Cat> cats = new List<Cat>
            {
                new Tomcat("Misho", 3),
                new Kitten("Pisana", 5),
                new Kitten("Emma", 1)
            };

            double catsAverageAge = cats.Average(x => x.Age);
            double dogsAverageAge = dogs.Average(x => x.Age);
            double frogsAverageAge = frogs.Average(x => x.Age);
            Console.WriteLine("Average age of frogs is: {0:F2} years", frogsAverageAge);
            Console.WriteLine("Average age of cats is: {0:F2} years", catsAverageAge);
            Console.WriteLine("Average age of dogs is: {0:F2} years", dogsAverageAge);
            Console.WriteLine("Average age of all animals is: {0:F2} years", (frogsAverageAge + catsAverageAge + dogsAverageAge)/3);
        }
    }
}