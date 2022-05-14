using Course_Managment_Appilaction.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Managment_Appilaction.Interfaces
{
    class CourseService : ICourseService
    {

        List<Group> _Groups;
        public List<Group> Groups => _Groups;

        public string CreateGroup(string no, Catagories catagory, bool isOnline)
        {
            Group group = new Group(no, catagory, isOnline);

            if (_Groups.Count == 0)
            {
                Groups.Add(group);
                return $"{group.No} Creating Process has done Succesfully";
            }


            foreach (Group existedGroup in Groups)
            {
                if (group.No.ToLower().Trim() != existedGroup.No.ToLower().Trim())
                {
                    _Groups.Add(group);
                    return $"{group.No} successfully created";
                }

            }
            return $"Hall cannot create \nAlready hall is existed";
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
            Group group = FindGroup(OldNo);
            if (FindGroup(NewNo) == null)
            {
                if (group != null)
                {
                    group.No = NewNo.ToUpper().Trim();
                    Console.WriteLine($"{group.No} successfully edited");
                }
                else
                {
                    Console.WriteLine($"There is no hall => {OldNo.ToUpper()}");
                }
            }
            else
            {
                Console.WriteLine($"There is hall => {NewNo.ToUpper()}");
            }
        }
        public void ShowGroups()
        {
            if(Groups.Count > 0)
            {
                foreach (Group group in Groups)
                {
                    Console.WriteLine(group);
                }
            }
        }

        public void CreateStudent(string fullname, byte enter_point, string group_no)
        {
            Student student = new Student(fullname, enter_point, group_no);

            Group group = new Group();
            group.StudentList.Add(student); // is contunie

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
