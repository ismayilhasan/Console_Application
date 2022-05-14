using Course_Managment_Appilaction.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Managment_Appilaction
{
    static class MenuServives
    {
        public static CourseService courseService= new CourseService();

        static object category;
        static string No;
        static bool 
        public static void CreateGroup()
        {
            Console.WriteLine("Write Group Category");
            bool ResultofCategory = Enum.TryParse(typeof (Catagories),Console.ReadLine(),out category );
            No = Console.ReadLine();

            if(!string.IsNullOrEmpty(No) || !string.IsNullOrWhiteSpace(No)
            {
                
            }
            else
            {
                Console.WriteLine("Please enter Correct Group No");
                No = Console.ReadLine();
            }
            
        }

    }
}
