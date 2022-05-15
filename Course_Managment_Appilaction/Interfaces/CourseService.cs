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
            Console.WriteLine($"{group}  has done Succesfully");


         
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
                    Console.WriteLine($"Group :{group.No} {group.setLimit(group.IsOnline)}");
                }
            }
        }

        public void CreateStudent(string fullname, byte enter_point, string group_no)
        {
            Student student = new Student(fullname, enter_point, group_no);

            _students.Add(student);

            
            

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

      

        public void ShowStudentsByGroup()
        {
            throw new NotImplementedException();
        }

        
       
    }
}
