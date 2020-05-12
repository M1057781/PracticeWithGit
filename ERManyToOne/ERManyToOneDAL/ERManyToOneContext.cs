using ERManyToOneEntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERManyToOneDAL
{
    public class ERManyToOneContext : DbContext
    {
        public ERManyToOneContext():base("connection")
        {

        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }

    }
}
