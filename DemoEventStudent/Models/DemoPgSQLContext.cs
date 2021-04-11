using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEventStudent.Models
{
    public class DemoPgSQLContext : IdentityDbContext<ApplicationUser>
    {
        public DemoPgSQLContext(DbContextOptions<DemoPgSQLContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrderDetail>().HasKey(od => new { od.BookId, od.OrderId });

            // Seeding DATA
            modelBuilder.Entity<Book>().HasData(
                 new Book {
                     BookId = 1, 
                     BookName = "Toán" 
                 },
                 new Book { 
                     BookId = 2, 
                     BookName = "Văn" 
                 },
                 new Book { 
                     BookId = 3, 
                     BookName = "Anh" 
                 }
             );
            modelBuilder.Entity<Order>().HasData(
                 new Order { OrderId = 1 },
                 new Order { OrderId = 2 }
             );
            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail { 
                    OrderId = 1,
                    BookId = 1
                },
                new OrderDetail
                {
                    OrderId = 1,
                    BookId = 3
                },
                new OrderDetail
                {
                    OrderId = 2,
                    BookId = 2
                }
            );
        }


        // ** 1 - 1 **
        //modelBuilder.Entity<Student>()
        //    .HasOne<StudentAddress>(s => s.Address)
        //    .WithOne(ad => ad.Student)
        //    .HasForeignKey<StudentAddress>(ad => ad.AddressOfStudentId);

        // ** n - 1 **
        //modelBuilder.Entity<Student>()
        // .HasOne<Grade>(s => s.Grade)
        // .WithMany(g => g.Students)
        // .HasForeignKey(s => s.CurrentGradeId);


        // ** n - n **
        //modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.SId, sc.CId});

        //modelBuilder.Entity<StudentCourse>()
        //    .HasOne<Student>(sc => sc.Student)
        //    .WithMany(s => s.StudentCourses)
        //    .HasForeignKey(sc => sc.SId);


        //    modelBuilder.Entity<StudentCourse>()
        //    .HasOne<Course>(sc => sc.Course)
        //    .WithMany(s => s.StudentCourses)
        //    .HasForeignKey(sc => sc.CId);
    }
}
