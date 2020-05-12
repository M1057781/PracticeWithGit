using ERManyToOneEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERManyToOnePresentationLayer.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}