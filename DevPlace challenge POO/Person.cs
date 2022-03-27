using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevPlace_challenge_POO
{
    //Define la clase Person
    public class Person
    {
        //Crea un constructor geters y seters para los atributos
        public Person(string name, string surname, string birthday)
        {
            FirstName = name;
            LastName = surname;
            BirthDay = birthday;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDay { get; set; }

        //Sobrecarga el metodo toString para que muestre el nombre y apellido
        override public string ToString()
        {
            Console.WriteLine("Nombre:" + FirstName + "- Apellido:" + LastName);
            return "Nombre:" + FirstName + "- Apellido:" + LastName;
        }

        //Define el metodo myInfo que muestra los datos de la instancia
        public void MyInfo()
        {
            Console.WriteLine("Nombre: " + FirstName + " - Apellido: " + LastName + " - Cumpleaños: " + BirthDay);
        }

        //Define un metodo que devuelve la informacion de la instancia en forma de array
        public string[] InfoArray()
        {
            string[] info = new string[3] { FirstName, LastName, BirthDay };
            return info;
        }
    }
}
