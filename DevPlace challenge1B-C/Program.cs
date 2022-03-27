using System;
using System.Text.RegularExpressions;

namespace DevPlace_challenge1B
{
    class Program
    {
        static void Main(string[] args)
        {
            programaSuma();
        }





        private static void programaSuma()
        {
            //Crea la variable para la suma y el array a llenar
            int[] numeros = new int[5];
            int suma = 0;




            //cinco veces pide un numero y lo valida 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("introdusca un numero");
                string numStr = Console.ReadLine();



                //Si realmente es un numero lo suma y lo agrega al array 
                if (Regex.IsMatch(numStr, @"^[0-9]+$"))
                {
                    int num = Convert.ToInt32(numStr);
                    numeros[i] = num;
                    suma += num;
                }
                //si no es un numero le pide al usuario que reintente el proceso
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("El valor ingresado no es un numero positivo! intente otra vez:");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    programaSuma();
                }
            }




            //Muestra los numeros en orden inverso y luego la suma de ellos
            Console.WriteLine("");
            Console.WriteLine("La suma de los numeros:");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Es igual a: " + suma);




            //Muestra el arreglo ordenado 
            Console.WriteLine("");
            Console.WriteLine("Numeros ordenados de menor a mayor:");
            int[] numerosOrdenados = ordenarArreglo(numeros);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(numeros[i]);
            }





            //Muestra los numeros repetidos si es que hay
            Console.WriteLine("");
            numRepetidos(numerosOrdenados);
        }









        //Ordena el array
        private static int[] ordenarArreglo(int[] numeros)
        {
            Array.Sort(numeros);
            return numeros;
        }










        //Indica los numeros repetidos y cuantas veces se repiten
        static void numRepetidos(int[] numbers)
        {
            //Genera las variables a partir de el array 
            int large = numbers.Length;
            int[] list = new int[large];

            //Compara los numeros entre si
            for (int i = 0; i < large; i++)
            {
                int count = 0;
                for(int j = 0; j < large; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                        if (numero(numbers[i]))
                        {
                            list[i] = numbers[i];
                        }
                    }
                }
                if (list[i] != 0)
                {
                    //Solo muestra el numero si esta mas de una vez 
                    if (count > 1)
                    {
                        Console.WriteLine("El numero " + list[i] + " esta " + count + " veces");
                    }
                }
            }
            //Verifica si el numero esta en la lista
            bool numero (int num)
            {
                for(int i = 0; i < large; i++)
                {
                    if(list[i] == num)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
