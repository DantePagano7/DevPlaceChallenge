using System;

namespace DevPlace_challenge1F
{
    class Program
    {
        static void Main(string[] args)
        {
            parParImpar();
        }


        //Crea series de numeros entre 0 y 1000 hasta alcanzar la conbinacion par,par,impar
        private static void parParImpar()
        {
            //Crea dos variables para controlar el bucle central y llevar una cuenta de sus iteraciones
            int contador = 0;
            bool logrado = false;

            //Crea el bucle central 
            while (!logrado)
            {
                //Crea los numeros al azar 
                Random number = new Random();
                int number1 = number.Next(0, 1000);
                int number2 = number.Next(0, 1000);
                int number3 = number.Next(0, 1000);

                //Valida que el conjunto de numeros actual, suma el nuevo intento a la lista y termina el bucle
                if ((number1 % 2) == 0 && (number2 % 2) == 0 && (number3 % 2) != 0)
                {
                    logrado = true;
                    contador++;
                    Console.WriteLine("");
                    Console.WriteLine("Se a logrado la combinacion de los numeros par-par-impar.");
                    Console.WriteLine("Numero de intentos realizados: " + contador);
                }
                //Si el conjunto de numeros no es valido suma el intento a la lista y deja que se reinicie el bucle
                else
                {
                    contador++;
                    Console.WriteLine("");
                    Console.WriteLine("No se consiguio par,par,impar");                  
                    Console.WriteLine("Presione la tecla <Enter> para intentarlo de nuevo");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                }
            }
        }
    }
}
