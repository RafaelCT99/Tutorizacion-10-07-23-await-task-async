using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StudentAddress>().HasKey(v => v.StudentID);
        }

        public async Task<Student> GetStudentByIdAsync(int studentId)
        {
            // Lógica para obtener un estudiante por su identificador de forma asíncrona
            await Task.Delay(100); // Ejemplo de espera simulada

            return await Students.FindAsync(studentId);
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            // Lógica para obtener todos los estudiantes de forma asíncrona
            await Task.Delay(100); // Ejemplo de espera simulada

            return await Students.ToListAsync();
        }

        public async Task<Student> CreateStudentAsync(Student student)
        {
            // Lógica para crear un estudiante de forma asíncrona
            await Task.Delay(100); // Ejemplo de espera simulada

            Students.Add(student);
            await SaveChangesAsync();

            return student;
        }

        public async Task<Student> UpdateStudentAsync(Student student)
        {
            // Lógica para actualizar un estudiante de forma asíncrona
            await Task.Delay(100); // Ejemplo de espera simulada

            Students.Update(student);
            await SaveChangesAsync();

            return student;
        }

        public async Task<bool> DeleteStudentAsync(int studentId)
        {
            // Lógica para eliminar un estudiante de forma asíncrona
            await Task.Delay(100); // Ejemplo de espera simulada

            var student = await Students.FindAsync(studentId);
            if (student != null)
            {
                Students.Remove(student);
                await SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
