using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Managment_Appilaction
{
    class Group
    {
        public string No;
      
        public bool IsOnline;
        byte Limit;
        
        public List<Student> StudentList;
        Catagories Catagory = new Catagories();
        public static int Count;
        public static int Count_group;

        public Group()
        {
            StudentList = new List<Student>();
        }
        static Group()
        {
            Count = 100;
            Count_group = 0;
        }

        public byte setLimit(bool isOnline)
        {
            if (isOnline == true)
            {
                Limit = 15;
                return Limit;
            }
            else
            {
                Limit = 10;
                return Limit;
            }
        }
        

       



        public Group( Catagories catagory, bool isOnline)
        {
            switch (catagory)
            {
                case Catagories.Programming:
                    No = $"P" + Count;
                    break;
                case Catagories.Desing:
                    No = $"D" + Count;
                    break;
                case Catagories.System_Administration:
                    No = $"SA" + Count;
                    break;
                default:
                    break;
            }

            
            Catagory = catagory;
            IsOnline = isOnline;
            Count++;
            Count_group++;

            //Categories = category;

            //IsOnline = isonline;
            //++Count;
            //CountName++;
            //Count++;


        }

        public override string ToString()
        {
            return $"{No},{Catagory}";
        }


    }
}