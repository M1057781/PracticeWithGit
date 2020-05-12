using ERManyToOneEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERManyToOneDAL
{
    public class ERManyToOneData:IERManyToOneData
    {
        ERManyToOneContext context = new ERManyToOneContext();
        public void AddCourses(Course course)
        {
            context.Course.Add(course);
            context.SaveChanges();
        }
        public List<Course> GetCourses()
        {
            List<Course> courses = new List<Course>();
            courses = context.Course.ToList();
            context.SaveChanges();
            return courses;
        }
        public void AddStudents(Student student)
        {
            context.Student.Add(student);
            context.SaveChanges();
        }
        public List<Student> GetStudents()
        {
            List<Student> students = context.Student.ToList();
            context.SaveChanges();
            return students;
        }
        public void UpdateCourse(Course course)
        {
            Course updatedCourse = context.Course.Single(c => c.CourseId == course.CourseId);
            updatedCourse.CourseName = course.CourseName;
            updatedCourse.Duration = course.Duration;
            context.SaveChanges();
        }
        public void DeleteStudent(int StudentId)
        {
            Student student=context.Student.Find(StudentId);
            context.Student.Remove(student);
        }
    }
}
