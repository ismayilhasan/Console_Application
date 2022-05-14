using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Managment_Appilaction
{
    class Group
    {
        public string No;
        public int GroupCount;
        public bool IsOnline;
        byte Limit;
        Student student;
        public List<Student> StudentList;
        Catagories Catagory = new Catagories();

        public Group()
        {

        }
        public byte CheckLimit 
        {
           get
           {
                return Limit;
           }
          set
           {
                if (IsOnline == true)
                {
                    Limit = 15;
                    StudentList = new List<Student>(Limit);
                }
                else
                {
                    Limit = 10;
                    StudentList = new List<Student>(Limit);
                }
            }


        }

       



        public Group(string no, Catagories catagory, bool isOnline)
        {
            switch (catagory)
            {
                case Catagories.Programming:
                    No = $"P" + GroupCount;
                    break;
                case Catagories.Desing:
                    No = $"D" + GroupCount;
                    break;
                case Catagories.System_Administration:
                    No = $"SA" + GroupCount;
                    break;
                default:
                    break;
            }

            No = no;
            Catagory = catagory;
            IsOnline = isOnline;

           
        }
        

    }
}