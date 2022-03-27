using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBchallenge
{
    //Define la base de datos, separada en 2 arrays de objetos conserva la constitucion de base de datos SQL
    public class BaseDeDatos
    {
        public int Id { get; set; }
        public Alumno[] Al { get; set; }
        public Universidad[] Un { get; set; }
    }
}
