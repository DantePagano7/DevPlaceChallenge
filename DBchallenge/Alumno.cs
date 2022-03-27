using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBchallenge
{

    //Define la clase alumno, sus atributos y constructor
    public class Alumno
    {
        public Alumno(int id, string nombre, string apellido, int telefono, string email, int universidad, int[] promediosPorMateria)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Email = email;
            Universidad = universidad;
            PromediosPorMateria = promediosPorMateria;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public int[] PromediosPorMateria { get; set; }
        public int Universidad { get; set; }
    }

}
