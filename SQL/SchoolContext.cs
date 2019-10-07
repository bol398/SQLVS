using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQL
{
    public class SchoolContext : DbContext
    {
        private const string connectionString = "Server=localhost;Database=KurserEleverCodeFirst;Trusted_Connection=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Kurs> Kurser { get; set; }
        public DbSet<KursStudent> KursStudents { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentBetyg> StudentBetyg { get; set; }
    }
}
