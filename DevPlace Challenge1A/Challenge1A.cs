using System;

namespace DevPlace_Challenge
{
    class Challenge1A
    {
        static void Main(string[] args)
        {
            ProgramaIntervalo();
        }







        //La funcion inicial del programa 
        private static void ProgramaIntervalo()
        {
            //El try catch verifica que el valor ingresado sea un numero sin usar foreach ni ningun otro metodo
            //(no es recomendable para la mayoria de las situaciones pero es extremadamente simple y rapido)
            try
            {
                Console.WriteLine("Ingrese el primer numero para el intervalo");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo numero para el intervalo");
                int num2 = Convert.ToInt32(Console.ReadLine());

                //Pregunta por contiguidad y negatividad de los parametros
                if (numerosSonValidos(num1,num2))
                {
                    //Ordena los numeros de menor a mayor a la hora de ingresarlos en la funcion
                    if (num1 < num2)
                    {
                        MostrarIntervalo(num1, num2);
                    }
                    else
                    {
                        MostrarIntervalo(num2, num1);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Caracter incorrecto! intente nuevamente:");
                Console.WriteLine("");
                ProgramaIntervalo();
            }
        }









        //Recibe los dos numeros parametrales validados y muestra los/el numero del intervalo 
        private static void MostrarIntervalo(int numA, int numB)
        {
            Console.WriteLine("El intervalo lo componen:");
            Console.WriteLine("");
            numA++;

            //selecciona un numero del intervalo
            for (int i = numA; i < numB; i++)
            {
                //pregunta si el numero es primo
                if (esPrimo(i))
                {
                    Console.WriteLine(i + " es primo");
                }
                else
                {
                    Console.WriteLine(i + " no es primo");
                }
            }
        }








        //verifica si el numero es primo 
        static bool esPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    // No es primo
                    return false;
                }
            }
            // Es primo
            return true;
        }








        //Valida que los numeros no sean contiguos y que no sean negativos
        static bool numerosSonValidos(int num1, int num2)
        {
            if (num1 - num2 <= 1 && num2 - num1 <= 1)
            {
                Console.WriteLine("Los caracteres seleccionados no tienen intervalo entre si! intente nuevamente:");
                Console.WriteLine("");
                ProgramaIntervalo();
                return false;
                //Son contiguos
            }
            if (num1 < 0 || num2 < 0)
            {
                Console.WriteLine("Caracter negativo seleccionado! intente nuevamente:");
                Console.WriteLine("");
                ProgramaIntervalo();
                return false;
                //Es negativo uno de los dos
            }
            return true;
        }
    }
}
