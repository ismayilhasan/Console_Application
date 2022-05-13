using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Managment_Appilaction.Models
{
    interface ICourseService
    {
        public String CreateGroup();

        public void ShowGroups();

        public string EditGroups();

        public void ShowStudentsByGroup();

        public void ShowAllStudents();

        public void CreateStudent();

        public void DeleteStudent();

    }
}
