using ERManyToOnePresentationLayer.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace ERManyToOnePresentationLayer.Controllers
{
    public class ManyToOneController : ApiController
    {
        ModelManager model = new ModelManager();
        [HttpGet]
        [Route("api/GetCourses")]
        public IHttpActionResult GetCourses()
        {
            //Fetching the data from the database
            List<CourseModel> courses = model.GetCourses();
            return Ok(courses);
        }
        [HttpPost]
        [Route("api/AddCourses")]
        public IHttpActionResult AddCourses([FromBody]CourseModel courseModel)
        {
            model.AddCourses(courseModel);
            return Ok();
        }
        [HttpPost]
        [Route("api/AddStudents")]
        public IHttpActionResult AddStudents([FromBody]StudentModel studentModel)
        {
            model.AddStudents(studentModel);
            return Ok();
        }
        [HttpGet]
        [Route("api/GetStudents")]
        public IHttpActionResult GetStudents()
        {
            List<StudentModel> studentModels = model.GetStudents();
            return Ok(studentModels);
        }
        [HttpPut]
        [Route("api/UpdateCourse/CourseId")]
        public IHttpActionResult UpdateCourse(CourseModel courseModel)
        {
            model.UpdateCourse(courseModel);
            return Ok();
        }
        [HttpDelete]
        [Route("api/DeleteStudent/StudentId")]
        public IHttpActionResult DeleteStudent(int StudentId)
        {
            model.DeleteStudent(StudentId);
            return Ok();
        }
    }
}
