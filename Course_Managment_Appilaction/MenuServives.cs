﻿using Course_Managment_Appilaction.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Managment_Appilaction
{
    static class MenuServives
    {
        public static CourseService courseService= new CourseService();

        public static void CreateGroup()
        {
            Group group = new Group();
            object category;
            string answer; 

            Console.WriteLine("Please, Enter Which Category Do You Want To Study ");


            foreach (var item in Enum.GetValues(typeof(Catagories)))
            {
                Console.WriteLine($"{(int)item}. {item}");
            }

            bool resultCategory = Enum.TryParse(typeof(Catagories), Console.ReadLine(), out category);

            Console.WriteLine("is it Group online Yes/No");
            answer = Console.ReadLine();
            if (answer.ToLower().Trim() == "yes")
            {
                group.IsOnline = true;
            }
            else if(answer.ToLower().Trim() == "no")
            {
                group.IsOnline = false;
            }
            else
            {
                Console.WriteLine("invalid answer \nPlease only yes or not ");
               
            }


            if (resultCategory)
            {
                courseService.CreateGroup((Catagories)category, group.IsOnline);
            }

        }

        public static void EditGroup()
        {

            Console.WriteLine("Please, enter Group No");
            string OldNum = Console.ReadLine();
            Console.WriteLine("Please, enter New Group No");
            string NewNum = Console.ReadLine();
            courseService.EditGroup(OldNum, NewNum);
        }

        public static void ShowAllGroup()
        {
            courseService.ShowGroups();
        }

        public static void CreateStudent()
        {
            Console.WriteLine("Enter the Fullname");
            string fullname = Console.ReadLine();
            Console.WriteLine("Enter Your Entry Point");
            byte enterpoint = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Group Name");
            string groupNum = Console.ReadLine();
          
            courseService.CreateStudent(fullname,enterpoint,groupNum);
        }


        public static void ShowAllStudents()
        {
            courseService.ShowAllStudents();
        }

        public static void ShowStudentsByGroup()
        {
            Console.WriteLine("Enter Group Number");
            string groupNumber = Console.ReadLine();
            courseService.ShowStudentsByGroup(groupNumber);
        }
    }
}

    
