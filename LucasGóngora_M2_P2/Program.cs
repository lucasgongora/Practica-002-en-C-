  using System;

namespace LucasGóngora_M2_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            int funcion = 0;
            do
            {
                Console.WriteLine("\n ******************  Bienvenido !!!!! Elija la función que quiere utilizar:\n\n(1)-Numero entre 1 y 10.\n(2)-Suma de 2 Numeros." +
                "\n(3)-Apariencia de Imagen.\n(4)-Temperatura de café.\n(5)-Divisibles por 3.\n(6)-Multisuma.\n(7)-Adivinar numero.\n(8)-Salir. \n\n");
                Console.Write(">>>>>>FUNCION: ");
                funcion = int.Parse(Console.ReadLine());
            
                switch (funcion)
                {
                    case 1:
                        Console.Clear();
                        Diez programa1 = new Diez();
                        programa1.Numeros();
                        break;
                    case 2:
                        Console.Clear();
                        Dos programa2 = new Dos();
                        programa2.Suma();
                        break;
                    case 3:
                        Console.Clear();
                        Imagen programa3 = new Imagen();
                        programa3.Apariencia();
                        break;
                    case 4:
                        Console.Clear();
                        Cafe programa4 = new Cafe();
                        programa4.Temperatura();
                        break;
                    case 5:
                        Console.Clear();
                        Divisibles programa5 = new Divisibles();
                        programa5.Tres();
                        break;
                    case 6:
                        Console.Clear();
                        Multisuma programa6 = new Multisuma();
                        programa6.Detener();
                        break;
                    case 7:
                        Console.Clear();
                        Adivinar programa7 = new Adivinar();
                        programa7.Game();
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("\n\n            Usted ha salido de la aplicacion. gracias y hasta pronto !!!!");
            } while (funcion != 8);
        }
    }
}
