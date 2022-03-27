using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevPlace_challenge_POO
{
    //Define la clase Employee
    public class Employee : Person
    {
        //Define dos atributos extras para la clase Employee hija de Person
        public Employee(string name, string surname, string birthday, int file, string departament) : base(name, surname, birthday)
        {
            File = file;
            Departament = departament;
        }

        public int File { get; set; }
        public string Departament { get; set; }

        //Define un nuevo metodo que muestra toda la informacion
        public void FullInfo()
        {
            Console.WriteLine("Nombre: " + FirstName + " - Apellido: " + LastName + " - Cumpleaños: " + BirthDay + " - File: " + File + " - Departament: " + Departament);
        }
    }
}
