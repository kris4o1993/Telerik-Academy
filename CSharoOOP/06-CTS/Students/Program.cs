namespace Students
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Pesho", "Goshov", "Ivanov", "9110111245", "Bobovdol, Slaveikov st 10", "0888-88-88-88", "ilikehornybitches@pornhub.com",
                "3", Universities.UNWE, Faculties.Informatics, Specialties.BusinessInformatics);

            Console.WriteLine(st);
            Student st2 = st.Clone();
            Console.WriteLine(st2);
        }
    }
}
