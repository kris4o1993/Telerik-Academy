namespace _03_Names
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public uint Age { get; set; }

        public override string ToString()
        {
            return String.Format("First name: {0} \nLast Name: {1} \nAge: {2}\n", this.FirstName, this.LastName, this.Age);
        }
    }
}
