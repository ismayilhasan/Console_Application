using System;
using System.Collections.Generic;

namespace Course_Managment_Appilaction
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Course Managment Application");
            int selection;

            do
            {
                Console.WriteLine("1. Create Group");
                Console.WriteLine("2. Edit Group");
                Console.WriteLine("3. Show Groups");
                Console.WriteLine("4.Create Student");
                Console.WriteLine("5 .Show all Student");
                Console.WriteLine("6. Remove Student");
                Console.WriteLine("7. Show Student by Group");
                Console.WriteLine("8. Exit");

                bool result = int.TryParse(Console.ReadLine(), out selection);
                Console.Clear();

                switch (selection)
                {
                    case 1:
                        MenuServives.CreateGroup();
                        break;

                    case 2:
                        MenuServives.EditGroup();
                        break;
                    case 3:
                        MenuServives.ShowAllGroup();
                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                }
            } while (selection != 0);
            
            



        }
    }
}
