using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class BaseKisi
    {
        public string? Name {  get; set; }
        public string? Surname { get; set; }

        public void WriteName()
        {
            Console.WriteLine($"İsim: {Name} \nSoyisim: {Surname}");
        }
    }

    public class Teacher : BaseKisi
    {
        public int Salary { get; set; }
        public void WriteSalary ()
        {
            Console.WriteLine("Öğretmen:");
            WriteName();
            Console.WriteLine($"Maaş miktarı: {Salary} TL \n");          
        }
    }

    public class Student : BaseKisi
    {
        public int StudentNumber { get; set; } 
        public void WriteNumber()
        {
            Console.WriteLine("Öğrenci:");
            WriteName();
            Console.WriteLine($"Öğrenci numarası: {StudentNumber} \n");           
        }
    }
}
