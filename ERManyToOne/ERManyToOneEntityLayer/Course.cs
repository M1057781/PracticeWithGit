﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERManyToOneEntityLayer
{
    [Table("Course")]
    public class Course
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int Duration { get; set; }

        public List<Course> Student { get; set; }

    }
}
