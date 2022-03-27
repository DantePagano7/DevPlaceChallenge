using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBchallenge
{
    //Define la clase Universidad, sus atributos y constructor
    public class Universidad
    {
        public Universidad(int id, string nombre, string localidad, string provincia)
        {
            Id = id;
            Nombre = nombre;
            Localidad = localidad;
            Provincia = provincia;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
    }
}
