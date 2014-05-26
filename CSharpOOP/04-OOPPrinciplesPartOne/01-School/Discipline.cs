namespace School
{
    using System;
    class Discipline
    {
        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public string Name { get; set; }

        public int NumberOfLectures { get; set; }

        public int NumberOfExercises { get; set; }

        public override string ToString()
        {
            return String.Format("DISCIPLINE NAME: {0} \nNUMBER OF LECTURES: {1} \nNUMBER OF EXERCISES: {2} \n\n", 
                this.Name, this.NumberOfLectures, this.NumberOfExercises);
        }
    }
}
