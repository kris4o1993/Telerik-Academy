namespace Animals
{
    using System;
    class Dog : Animal, ISound
    {
        public Dog(string name, int age, string sex)
            :base(name, age, sex)
        {

        }

        public void Sound()
        {
            Console.WriteLine("Bauuuu!");
        }
    }
}
