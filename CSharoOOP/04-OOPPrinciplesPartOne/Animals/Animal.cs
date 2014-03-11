using System;

namespace Animals
{
    public abstract class Animal : ISound
    {
        private string name;
        private string sex;
        private int age; 

        public void Sound()
        {
            Console.WriteLine("I dont know what I am...");
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                this.age = value;
            }
        }

        public string Sex
        {
            get
            {
                return this.sex;
            }
            private set
            {
                this.sex = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }


        public Animal(string name, int age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
    }
}
