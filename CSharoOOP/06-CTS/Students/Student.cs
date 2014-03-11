
namespace Students
{
    using System;
    class Student : ICloneable
    {
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public string SocialSecurityNumber { get; private set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Course { get; private set; }
        public Universities University { get; private set; }
        public Faculties Faculty { get; set; }
        public Specialties Speciality { get; set; }

        public Student(string firstName, string middleName, string lastName,
            string socialSecurityNumber, string address, string mobilePhone, string email, string course,
            Universities university, Faculties faculty, Specialties speciality)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SocialSecurityNumber = socialSecurityNumber;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Speciality = speciality;
        }

        public override bool Equals(object obj)
        {
            Student st = obj as Student;

            if (this.SocialSecurityNumber == st.SocialSecurityNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Student st1, Student st2)
        {
            return true;
        }


        public static bool operator !=(Student st1, Student st2)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return LastName.GetHashCode() ^ SocialSecurityNumber.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format(
                "*********************************************** \n"
                + "STUDENT INFORMATION \n"
                + "*********************************************** \n"
                + "Student name: {0} {1} {2} \n"
                + "Social security number: {3} \n"
                + "Address: {4} \n" 
                + "Mobile phone: {5} \n"
                + "Email: {6} \n"
                + "Course: {7} \n"
                + "University {8} \n"
                + "Faculty {9} \n"
                + "Speciality {10} \n",
                this.FirstName, this.MiddleName, this.LastName, this.SocialSecurityNumber ,this.Address, this.MobilePhone, this.Email, this.Course, 
                this.University, this.Faculty, this.Speciality
                );
        }

        

        public Student Clone()
        {
            Student clone = new Student(
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.SocialSecurityNumber,
                this.Address,
                this.MobilePhone,
                this.Email,
                this.Course,
                this.University,
                this.Faculty,
                this.Speciality
                );

            return clone;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }
    }
}
