using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConsumeApiToAngularStudent.Model;

namespace ConsumeApiToAngularStudent.Data
{
    public class ConsumeApiToAngularStudentContext : DbContext
    {
        public ConsumeApiToAngularStudentContext (DbContextOptions<ConsumeApiToAngularStudentContext> options)
            : base(options)
        {
        }

        public DbSet<ConsumeApiToAngularStudent.Model.Student> Student { get; set; }
    }
}
