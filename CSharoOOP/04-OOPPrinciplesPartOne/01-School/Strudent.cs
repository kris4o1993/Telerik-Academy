namespace School
{
    using System;
    public class Student : Person
    {
        public Student(string name, int id)
            :base(name)
        {
            this.Id = id;
        }
        
        public int Id { get; private set; }

        public override string ToString()
        {
            return String.Format("STUDENT NAME: {0} \nSTUDENT ID: {1} \n\n", this.Name, this.Id);
        }

        
    }
}
