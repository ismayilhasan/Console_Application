using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Managment_Appilaction.Models
{
    interface ICourseService
    {

        public List<Group> Groups { get; }
        public String CreateGroup(string no, Catagories catagory, bool isOnline);

        public void ShowGroups();

        public void EditGroup(string OldNo, string NewNo);

        public void ShowStudentsByGroup();

        public void ShowAllStudents();

        public void CreateStudent(string fullname, byte enter_point, string group_no);

        public void RemoveStudent();
        

    }
}
