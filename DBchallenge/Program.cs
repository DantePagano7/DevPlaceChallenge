using System;

namespace DBchallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseDeDatos DB1 = new();
            LlenarBaseDeDatos(DB1);
            ObtenerInformacion(DB1);
        }






        //Llena las tablas de la base de datos con datos ficticios
        private static void LlenarBaseDeDatos(BaseDeDatos DB)
        {
            //Declara strings con nombres y apellidos para ir mezclando
            string[] nombres = new string[10] { "Ivan", "Daniel", "Oliver", "Mark", "Joel", "Jonathan", "Elias", "Jose", "Raimundo", "Martin" };
            string[] apellidos = new string[10] { "Espin", "Delgado", "Morillas", "Arjona", "Idalgo", "Velasco", "Muñoz", "Cañales", "Arce", "Montes" };

            //Crea los dos arreglos para almacenar las universidades y alumnos
            Universidad[] Universidades = new Universidad[3];
            Alumno[] Alumnos = new Alumno[30];

            //Instancia las universidades
            Universidades[0] = new(1,"Universidad de Buenos Aires","C.A.B.A.","Buenos Aires");
            Universidades[1] = new(2,"Universidad Catolica Argentina","C.A.B.A.","Buenos Aires");
            Universidades[2] = new(3,"Universidad Nacional de La Plata","La Plata","Buenos Aires");
            
            //Instancia los alumnos
            Random r = new();
            for (int i = 0; i < 30; i++)
            {
                string nombre = nombres[r.Next(0, 10)];
                Alumnos[i] = new Alumno(i, nombre, apellidos[r.Next(0, 10)], r.Next(100000000, 1000000000), nombre + "@gmail.com", r.Next(0, 3), new int[36]);

                for(int j = 0; j < 36; j++)
                {
                    Alumnos[i].PromediosPorMateria[j] = r.Next(1, 11);
                }
            }
            //Llena cada tabla de la base de datos con la informacion correspondiente
            DB.Un = Universidades;
            DB.Al = Alumnos;
        }





        //Obtiene la informacion de la base de datos y la muestra en pantalla sin importar el numero de alumnos o universidades que haya
        private static void ObtenerInformacion(BaseDeDatos DB)
        {
            Console.WriteLine("Los alumnos con mas 12 o mas materias con 7 son:");

            foreach (Alumno element in DB.Al)
            {

                int contadorDeSietes = 0;
                foreach (int nota in element.PromediosPorMateria)
                {
                    if (nota >= 7)
                    {
                        contadorDeSietes++;
                    }
                }

                if (contadorDeSietes >= 12)
                {
                    int universidad = element.Universidad;

                    Console.WriteLine("");
                    Console.WriteLine("" + element.Nombre + " " + element.Apellido);
                    Console.WriteLine("Nro de telefono: " + element.Telefono + "  /  Email: " + element.Email);
                    Console.WriteLine("Va a la: " + DB.Un[universidad].Nombre);
                    Console.WriteLine("En la localidad de: " + DB.Un[universidad].Localidad + " en la provincia de: " + DB.Un[universidad].Provincia);

                }
            }
        }
    }
}
