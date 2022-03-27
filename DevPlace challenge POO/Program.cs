using System;
using System.Linq;

namespace DevPlace_challenge_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancia las dos personas parametrizada y no parametrizada
            Person persona1 = new("Juan", "Fischer", "3/7/1992");
            Person persona2 = new("", "", "");


            //Usa los metodos ToString y MyInfo
            persona1.ToString();
            persona2.ToString();
            Console.WriteLine("");

            persona1.MyInfo();
            persona2.MyInfo();
            Console.WriteLine("");


            //Consulta si las dos instancias son iguales y muestra la respuesta por pantalla
            if (InstanciasSonIgualesEqual(persona1.InfoArray(), persona2.InfoArray()))
            {
                Console.WriteLine("Son iguales las 2 instancias");
            }
            else
            {
                Console.WriteLine("Son distintas las 2 instancias");
            }

            Console.WriteLine("");

            //Instancia la clase Employee y usa uno de sus metodos 
            Employee empleado = new Employee("Robert", "Whilee", "31/9/2024", 209264, "3-B");
            empleado.FullInfo();
        }




        //Valida si dos instancias de Person son iguales usando Equal
        private static bool InstanciasSonIgualesEqual(string[] personaA, string[] personaB)
        {
            return Enumerable.SequenceEqual(personaA, personaB);
        }




        //Podria validar si dos instancias de Person son iguales sin usar Equal
        /*
           private static bool InstanciasSonIgualesSinEqual(string[] personaA, string[] personaB)
           {
               if (personaA[0] == personaB[0] && personaA[1] == personaB[1] && personaA[2] == personaB[2])
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }
        */
    }
}
