using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_Students.Model;

namespace CRUD_Students.Data
{
    public class CRUD_StudentsContext : DbContext
    {
        public CRUD_StudentsContext (DbContextOptions<CRUD_StudentsContext> options)
            : base(options)
        {
        }

        public DbSet<CRUD_Students.Model.Users> Users { get; set; } = default!;
    }
}
