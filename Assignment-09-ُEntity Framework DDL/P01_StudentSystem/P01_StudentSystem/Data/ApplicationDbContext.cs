using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data
{
    internal class ApplicationDbContext : DbContext
    {

        public DbSet<Course> courses {  get; set; }
        public DbSet<Student> students {  get; set; }
        public DbSet<Resource> resources {  get; set; }
        public DbSet<Homework> Homeworks {  get; set; }
        public DbSet<StudentCourse> studentCourses {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog = Student_System;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Homework>
                (
                    h =>
                    {
                        h.Property(b => b.Content).HasColumnType("varchar(255)");
                    }
                );
            modelBuilder.Entity<Resource>
                (
                    r =>
                    {
                        r.Property(p => p.Name).HasColumnType("nvarchar(50)");
                    }
                );
            modelBuilder.Entity<Course>
                (
                r =>
                {
                    r.Property(p => p.Name).HasColumnType("nvarchar(80)");
                }
                );
            modelBuilder.Entity<Resource>
                (
                    r =>
                    {
                        r.Property(p => p.Url).IsUnicode(false);
                    }
                );
            modelBuilder.Entity<Student>
                (
                    s =>
                    {
                        s.Property(p => p.Name).HasColumnType("nvarchar(100)");
                    }
                );
            modelBuilder.Entity<Student>
                (
                    r =>
                    {
                        r.Property(p => p.PhoneNumber).IsUnicode(false);
                    }
                );


            modelBuilder.Entity<StudentCourse>()
                .HasKey(c => new { c.CourseId, c.StudentId });


            // Seed Courses
            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    CourseId = 1,
                    Name = "C# Basics",
                    Description = "Intro to C#",
                    StartDate = new DateTime(2025, 8, 1),
                    EndDate = new DateTime(2025, 9, 1),
                    Price = 500
                },
                new Course
                {
                    CourseId = 2,
                    Name = "SQL for Beginners",
                    Description = "Learn SQL fast",
                    StartDate = new DateTime(2025, 8, 5),
                    EndDate = new DateTime(2025, 9, 5),
                    Price = 400
                }
            );

            // Seed Students
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    Name = "Yusif Trull",
                    Birthday = new DateTime(2000, 1, 1),
                    PhoneNumber = "0123456789",
                    RegisteredOn = true
                },
                new Student
                {
                    StudentId = 2,
                    Name = "Sarah Ahmed",
                    Birthday = new DateTime(2001, 5, 15),
                    PhoneNumber = "0111122223",
                    RegisteredOn = true
                }
            );

            // Seed Homework
            modelBuilder.Entity<Homework>().HasData(
                new Homework
                {
                    HomeworkId = 1,
                    Content = "files/assignment1.zip",
                    ContentType = ContentType.Zip,
                    SubmissionTime = new DateTime(2024, 7, 1, 10, 0, 0),
                    StudentId = 1,
                    CourseId = 1
                }
            );

            // Seed Many-to-Many (CourseStudent or studentCourses)
            modelBuilder.Entity<StudentCourse>()
            .HasKey(sc => new { sc.CourseId, sc.StudentId });

            modelBuilder.Entity<StudentCourse>().HasData(
                new StudentCourse { CourseId = 1, StudentId = 1 },
                new StudentCourse { CourseId = 2, StudentId = 2 }
            );


        }
    }
}
