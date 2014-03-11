namespace School
{
    using System;
    public abstract class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }

        private string name;

        public string Name 
        {
            get { return this.name; }
            set { this.name = value; }
        }
        
    }
}
