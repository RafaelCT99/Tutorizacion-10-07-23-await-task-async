using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public List<StudentCourse> StudentCourse { get; set; }

        public async Task<Course> CreateCourseAsync(Course course)
        {
            // Lógica para crear un curso de forma asíncrona
            await Task.Delay(100); // Ejemplo de espera simulada

            // Agregar la lógica necesaria para crear el curso en la base de datos

            return course;
        }

        public async Task<Course> UpdateCourseAsync(Course course)
        {
            // Lógica para actualizar un curso de forma asíncrona
            await Task.Delay(100); // Ejemplo de espera simulada

            // Agregar la lógica necesaria para actualizar el curso en la base de datos

            return course;
        }

        public async Task<bool> DeleteCourseAsync(int courseId)
        {
            // Lógica para eliminar un curso de forma asíncrona
            await Task.Delay(100); // Ejemplo de espera simulada

            // Agregar la lógica necesaria para eliminar el curso de la base de datos

            return true; // Cambiar el valor de retorno según corresponda
        }
    }
}
