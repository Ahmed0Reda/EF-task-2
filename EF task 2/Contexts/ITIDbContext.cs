using EF_task_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_task_2.Contexts
{
    public class ITIDbContext : DbContext
    {
        public ITIDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=CompanyDbG02; trusted_connection=true; TrustServerCertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasMany(x => x.Instructors).WithOne(x => x.Department).HasForeignKey("DeptId");
            modelBuilder.Entity<Department>().HasMany(x => x.Students).WithOne(x => x.Department).HasForeignKey("DeptId");
            modelBuilder.Entity<Topic>().HasMany(x => x.Courses).WithOne(x => x.Topic).HasForeignKey("TopicId");

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Topic> Topics { get; set; }



    }
}
