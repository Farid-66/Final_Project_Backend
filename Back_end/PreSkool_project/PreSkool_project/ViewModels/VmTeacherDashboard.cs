﻿using PreSkool_project.Models;
using System.Collections.Generic;

namespace PreSkool_project.ViewModels
{
    public class VmTeacherDashboard
    {
        public Teacher Teachers { get; set; }
        public List<ClassToSubject> ClassToSubjects { get; set; }
        public List<Exam> Exams { get; set; }
        public List<Holiday> Holidays { get; set; }
        public List<Library> Books { get; set; }
        public Salary Salaries { get; set; }
    }
}
