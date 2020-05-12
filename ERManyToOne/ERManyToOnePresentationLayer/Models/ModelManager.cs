using ERManyToOneBusinessLayer;
using ERManyToOneEntityLayer;
using System.Collections.Generic;


namespace ERManyToOnePresentationLayer.Models
{
    public class ModelManager
    {
        private IERManyToOneBusiness business = new ERManyToOneBusiness();

        public void AddCourses(CourseModel courseModel)
        {
            Course course = new Course();
            course.CourseName = courseModel.CourseName;
            course.Duration = courseModel.Duration;
            business.AddCourses(course);
        }
        public void AddStudents(StudentModel studentModel)
        {
            Student student = new Student();
            student.StudentName = studentModel.StudentName;
            student.Age = studentModel.Age;
            student.CourseId = studentModel.CourseId;
            business.AddStudents(student);
        }
        public List<CourseModel> GetCourses()
        {
            List<CourseModel> courseModels = new List<CourseModel>();
            List<Course> courses = business.GetCourses();
            foreach (Course course in courses)
            {
                CourseModel courseModel = new CourseModel();
                courseModel.CourseId = course.CourseId;
                courseModel.CourseName = course.CourseName;
                courseModel.Duration = course.Duration;
                courseModels.Add(courseModel);
            }
            return courseModels;
        }
        public List<StudentModel> GetStudents()
        {
            List<StudentModel> studentModels = new List<StudentModel>();
            List<Student> students = business.GetStudents();
            foreach(Student student in students)
            {
                StudentModel studentModel = new StudentModel();
                studentModel.StudentId = student.StudentId;
                studentModel.StudentName = student.StudentName;
                studentModel.Age = student.Age;
                studentModel.Course = new Course();
                studentModel.CourseId = student.CourseId;
                
                studentModels.Add(studentModel);
            }
            return studentModels;
        }
        public void UpdateCourse(CourseModel courseModel)
        {
            Course course = new Course();
            course.CourseId = courseModel.CourseId;
            course.CourseName = courseModel.CourseName;
            course.Duration = courseModel.Duration;
            business.UpdateCourse(course);

        }
        public void DeleteStudent(int StudentId)
        {
            business.DeleteStudent(StudentId);
        }
    }
}