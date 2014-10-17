namespace HumanFactory
{
    using System.Text;

    public class Human
    {
        public Gender Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public static Human CreateHuman(int magicalNumber)
        {
            Human newHuman = new Human();
            newHuman.Age = magicalNumber;
            if (magicalNumber % 2 == 0)
            {
                newHuman.Name = "Milcho";
                newHuman.Gender = Gender.Male;
            }
            else
            {
                newHuman.Name = "Kichka";
                newHuman.Gender = Gender.Female;
            }

            return newHuman;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Gender: {0}, Name: {1}, Age: {2}", this.Gender, this.Name, this.Age);

            return output.ToString();
        }
    }
}
