using System;

namespace DevPlace_challenge1D
{
    class Program
    {
        static void Main(string[] args)
        {
            piedraPapelTijera();
        }



        //Realiza un piedra papel o tijera PvP
        private static void piedraPapelTijera()
        {
            //El try proteje contra valores no numericos 
            try
            {
                //Setea la jugada del primer usuario 
                int jugada_del_usuario1, jugada_del_usuario2;
                Console.WriteLine("Selecciona el valor de jugada del usuario1.");
                Console.WriteLine("1- Piedra");
                Console.WriteLine("2- Papel");
                Console.WriteLine("3- Tijera");
                Console.Write("_ ");
                do
                {
                    jugada_del_usuario1 = int.Parse(Console.ReadLine());
                    if (jugada_del_usuario1 < 1 || jugada_del_usuario1 > 3)
                        Console.Write("Valor incorrecto. Ingr\u00E9salo nuevamente.: ");
                } while (jugada_del_usuario1 < 1 || jugada_del_usuario1 > 3);


                //Setea la jugada del segundo usuario 
                Console.WriteLine("Selecciona el valor de jugada del usuario2.");
                Console.WriteLine("1- Piedra");
                Console.WriteLine("2- Papel");
                Console.WriteLine("3- Tijera");
                Console.Write("_ ");
                do
                {
                    jugada_del_usuario2 = int.Parse(Console.ReadLine());
                    if (jugada_del_usuario2 < 1 || jugada_del_usuario2 > 3)
                        Console.Write("Valor incorrecto. Ingr\u00E9salo nuevamente.: ");
                } while (jugada_del_usuario2 < 1 || jugada_del_usuario2 > 3);

                //Calcula el ganador o el empate
                if (jugada_del_usuario2 == jugada_del_usuario1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Empate");
                }
                if ((jugada_del_usuario2 == 1 && jugada_del_usuario1 == 3) || (jugada_del_usuario2 == 2 && jugada_del_usuario1 == 1) || (jugada_del_usuario2 == 3 && jugada_del_usuario1 == 2))
                {
                    Console.WriteLine("");
                    Console.WriteLine("Gana el usuario2");
                }
                if ((jugada_del_usuario2 == 3 && jugada_del_usuario1 == 1) || (jugada_del_usuario2 == 1 && jugada_del_usuario1 == 2) || (jugada_del_usuario2 == 2 && jugada_del_usuario1 == 3))
                {
                    Console.WriteLine("");
                    Console.WriteLine("Gana el usuario1");
                }
                Console.WriteLine("");
                Console.Write("Presiona una tecla para terminar . . . ");
                Console.ReadKey();
            }
            //Reinicia el proceso si un usuario ingresa valores no numericos
            catch
            {
                Console.WriteLine("");
                Console.WriteLine("El valor ingresado no es un numero! Reintente el proceso:");
                Console.WriteLine("");
                piedraPapelTijera();
            }
        }
    }
}
