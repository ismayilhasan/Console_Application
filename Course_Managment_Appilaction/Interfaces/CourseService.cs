using Course_Managment_Appilaction.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Managment_Appilaction.Interfaces
{
    class CourseService : ICourseService
    {

        List<Group> _Groups = new List<Group>();
        List<Student> _students = new List<Student>();
        List<Student> Students => _students;
        public List<Group> Groups => _Groups;

        public void CreateGroup(Catagories catagory, bool isOnline)
        {
            Group group = new Group( catagory, isOnline);

            _Groups.Add(group);

            if(isOnline == true )
            {
                Console.WriteLine($"{group.No}  has done Succesfully");
            }
            else if(isOnline == false)
            {
                Console.WriteLine($"{group.No}  has done Succesfully");
            }
            else
            {
                Console.WriteLine("Try again ");
            }
            
           


         
        }

        public Group FindGroup(string no)
        {
            foreach (Group group in Groups)
            {
                if (group.No.ToLower().Trim() == no.ToLower().Trim())
                {
                    return group;
                }
            }
            return null;
        }


        public void EditGroup(string OldNo, string NewNo)
        {
            
            if (FindGroup(NewNo) == null)
            {
                Group group = FindGroup(OldNo);
                if (group != null)
                {
                    group.No = NewNo.ToLower().Trim();
                    Console.WriteLine($"{group.No} successfully created");
                }
                else
                {
                    Console.WriteLine($"There is no group for editing {OldNo.ToUpper()}");
                }
            }
            else
            {
                Console.WriteLine($"This Group which you edit already existed {NewNo.ToUpper()}");
            }
        }
        public void ShowGroups()
        {
            if(Groups.Count > 0)
            {
                foreach (Group group in Groups)
                {                    
                    if(group.IsOnline == true)
                    {
                        Console.WriteLine($"Group :{group.No}   status : online \n ");
                    }
                   
                }
            }
            else
            {
                Console.WriteLine("There is no group for showing \n");
            }
        }

        public void CreateStudent(string fullname, byte enter_point, string group_no)
        {
            if(Group.Count_group > 0)
            {
                Student student = new Student(fullname, enter_point, group_no);
               
                if(string.IsNullOrEmpty(student.Fullname) || string.IsNullOrWhiteSpace(student.Fullname))
                {
                    Console.WriteLine("invalid input \nStudent can not create ");
                    
                }
                else
                {
                    Console.WriteLine($"Name: {fullname}  Group Number{group_no}");
                    Students.Add(student);
                    Group group = new Group();
                    foreach (var existedstudent in FindGroup(group_no).StudentList)
                    {
                        if(existedstudent == student)
                        {
                            group.StudentList.Add(student);
                        }
                        else
                        {
                            Console.WriteLine("There is not this type of group");
                        }
                    }
                  
                }
            }
            else 
            {
                Console.WriteLine("There is no group for adding student");
            }

          
        }

        public void RemoveStudent()
        {
            throw new NotImplementedException();
        }

      

        public void ShowAllStudents()
        {
            foreach (Group group in Groups)
            {
                foreach (Student student in group.StudentList)
                {
                    Console.WriteLine($"Fullname : {student.Fullname} Group : {group} :   " );
                }
            }
        }

      

        public void ShowStudentsByGroup(string no)
        {
            Group group = FindGroup(no);
            if (group != null)
            {
                foreach (Student students in _students)
                {
                    Console.WriteLine(students);
                }
            }
            else
            {
                Console.WriteLine("There is no Student in Group");
            }
        }

        
       
    }
}
