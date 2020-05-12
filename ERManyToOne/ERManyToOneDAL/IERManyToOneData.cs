﻿using ERManyToOneEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERManyToOneDAL
{
    public interface IERManyToOneData
    {
        void AddCourses(Course course);
        List<Course> GetCourses();
        void AddStudents(Student student);
        List<Student> GetStudents();
        void UpdateCourse(Course course);
        void DeleteStudent(int StudentId);
    }
}
