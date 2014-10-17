using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_OrderAndSelect
{
    public class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public string GroupNumber { get; set; }
        public override string ToString()
        {
            return String.Format("First name: {0} \nLast Name: {1} \nFN: {2} \nTel: {3} \nEmail: {4} \nMarks: {5} \nGroup Number: {6}\n\n ",
                this.FirstName, this.LastName, this.FN, this.Tel, this.Email, String.Join(", ", this.Marks), this.GroupNumber);
        }
    }
}
