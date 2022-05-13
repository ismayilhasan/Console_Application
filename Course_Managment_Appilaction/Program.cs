using System;
using System.Collections.Generic;

namespace Course_Managment_Appilaction
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ismayil Hasanov", 100, "P324");
            Student student2 = new Student("Ismayil A", 80, "P34");

            Console.WriteLine(student.Id);
            Console.WriteLine(student2.Id);
            Console.WriteLine(Student.Count);
            
           
        }
    }
}
