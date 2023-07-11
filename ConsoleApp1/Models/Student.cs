using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public StudentAddress StudentAddress { get; set; }
        public List<StudentCourse> StudentCourse { get; set; }
    }

    public class StudentRepository
    {
        public async Task<Student> GetStudentByIdAsync(int studentId)
        {
            // Lógica para obtener un estudiante por su identificador de forma asíncrona
            await Task.Delay(100); // Ejemplo de espera simulada

            // Devolver el estudiante encontrado
            return new Student { StudentId = studentId, Name = "John", LastName = "Doe" };
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            // Lógica para obtener todos los estudiantes de forma asíncrona
            await Task.Delay(100); // Ejemplo de espera simulada

            // Devolver la lista de estudiantes encontrados
            return new List<Student>
            {
                new Student { StudentId = 1, Name = "John", LastName = "Doe" },
                new Student { StudentId = 2, Name = "Jane", LastName = "Smith" }
            };
        }

        public async Task<Student> CreateStudentAsync(Student student)
        {
            // Lógica para crear un estudiante de forma asíncrona
            await Task.Delay(100); // Ejemplo de espera simulada

            // Devolver el estudiante creado
            return student;
        }

        public async Task<Student> UpdateStudentAsync(Student student)
        {
            // Lógica para actualizar un estudiante de forma asíncrona
            await Task.Delay(100); // Ejemplo de espera simulada

            // Devolver el estudiante actualizado
            return student;
        }

        public async Task<bool> DeleteStudentAsync(int studentId)
        {
            // Lógica para eliminar un estudiante de forma asíncrona
            await Task.Delay(100); // Ejemplo de espera simulada

            // Devolver un indicador de éxito o fracaso
            return true;
        }
    }
}

