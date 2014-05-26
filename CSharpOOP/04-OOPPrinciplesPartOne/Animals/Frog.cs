namespace Animals
{
    using System;
    class Frog : Animal, ISound
    {
        public Frog(string name, int age, string sex)
            :base(name, age, sex)
        {

        }

        public void Sound()
        {
            Console.WriteLine("KWAK KWAK MOTHERFUCKER!");
        }
    }
}
