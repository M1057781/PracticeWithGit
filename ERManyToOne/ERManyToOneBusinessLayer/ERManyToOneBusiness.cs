using ERManyToOneDAL;
using ERManyToOneEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERManyToOneBusinessLayer
{
    public class ERManyToOneBusiness:IERManyToOneBusiness
    {
        private IERManyToOneData data = new ERManyToOneData();

        public void AddCourses(Course course)
        {
            data.AddCourses(course);
        }
        public List<Course> GetCourses()
        {
            List<Course> courses = data.GetCourses();
            return courses;
        }
        public void AddStudents(Student student)
        {
            data.AddStudents(student);
        }
        public List<Student> GetStudents()
        {
            List<Student> students = data.GetStudents();
            return students;
        }
        public void UpdateCourse(Course course)
        {
            data.UpdateCourse(course);
        }
        public void DeleteStudent(int StudentId)
        {
            data.DeleteStudent(StudentId);
        }
    }
}
