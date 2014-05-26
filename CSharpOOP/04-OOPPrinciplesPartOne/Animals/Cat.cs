namespace Animals
{
    using System;
    class Cat : Animal, ISound
    {
        public Cat(string name, int age, string sex)
            :base(name, age, sex)
        {

        }

        public void Sound()
        {
            Console.WriteLine("Myauuuu!");
        }
    }
}
