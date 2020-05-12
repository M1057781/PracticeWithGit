using ERManyToOneEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERManyToOnePresentationLayer.Models
{
    public class CourseModel
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int Duration { get; set; }

        public List<Course> Student { get; set; }
    }
}