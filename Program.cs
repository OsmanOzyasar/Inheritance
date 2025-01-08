using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Name = "Osman",
                Surname = "Özyaşar",
                StudentNumber = 159
            };

            student.WriteNumber();

            Teacher teacher = new Teacher()
            {
                Name = "Ökkeş",
                Surname = "Gılıbık",
                Salary = 50000
            };

            teacher.WriteSalary();
            
        }
    }
}