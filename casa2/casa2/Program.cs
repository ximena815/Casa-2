using System;

namespace casa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Bienvenido a casa 1 ;3");


            Random aleatorio = new Random();
            string respuesta = "s";
            int dado1 = 0, total = 0, tiroA= 0;
            double contador = 0;

            while (respuesta == "s" && total < 100)
            {
                Console.WriteLine("¿tirar los dados?");
                respuesta = Console.ReadLine();

                if (respuesta == "s")
                {
                    dado1 = aleatorio.Next(1, 13);
                    Console.WriteLine("tu dado1 es: " + dado1);
                    if (tiroA == 12 && dado1==10)
                    {
                        Console.WriteLine("has obtenido un logro en tu vida ganaste ;3");
                        string pajarito =
                              "\n  ^ ^" +
                              "\n (O,O)" +
                              "\n (   )" +
                              "\n  T T";
                        Console.WriteLine(pajarito);
                    }
                    if (contador > 2)
                    {
                        if(dado1 == 1 || dado1 == 3 || dado1 == 5 || dado1 == 7 || dado1 == 9 || dado1 == 11)
                        {
                            Console.WriteLine("salado mijo perdio");
                            respuesta = "n";
                        }
                    }

                    total += dado1;
                    Console.WriteLine("total actual: " + total);
                    contador++;
                    Console.WriteLine("contador: " + contador);
                }        
                else
                {
                    Console.WriteLine("que gallina se retiro");
                }
                tiroA = dado1;

            }
            if (total >= 100)
            {
                Console.WriteLine("has obtenido un logro en tu vida ganaste ;3");
                string pajarito =
                      "\n  ^ ^" +
                      "\n (O,O)" +
                      "\n (   )" +
                      "\n  T T";
                Console.WriteLine(pajarito);
            }
            

        }
    }
}
