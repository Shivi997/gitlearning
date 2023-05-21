using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcApplication3.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;  
        public int age { get; set;}
        public int mobileno { get; set; }

        public class StudentContext : DbContext
        {
            public DbSet<Student> Stud { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var strConnection = @"Data Source=W-674PY03-1;Initial Catalog=Shivam;Persist Security Info=True;User ID=sa;Password=Password@12345;TrustServerCertificate=True";
                base.OnConfiguring(optionsBuilder);
                optionsBuilder.UseSqlServer(strConnection);
            }
        }
        
    }
   }

