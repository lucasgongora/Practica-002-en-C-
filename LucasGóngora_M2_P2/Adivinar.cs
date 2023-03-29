using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasGóngora_M2_P2
{
    class Adivinar
    {
        public void Game()
        {
            Console.Clear();
            bool opcion = true;
            do
            {
                int oportunidades = 5;
                int n = 0;
                Console.Clear();
                Console.WriteLine("\n\n**********************  JUEGO DE ADIVINAR NUMERO **********************\n             ------- ADIVINA EL NUMERO, DEL 1 AL 10 -------\n\n");
                Random num = new Random();
                int numero = num.Next(1, 11);
                Console.WriteLine("\n\n>>>>>>>>>>>  Presiona ENTER para continuar >>>");
                Console.ReadKey();
                do
                {
                    Console.Clear();
                    Console.WriteLine("\n\n      OPORTUNIDADES = {0}            NUMERO SECRETO = **\n\n", oportunidades);
                    Console.Write("El numero es = ");
                    n = Convert.ToInt32(Console.ReadLine());
                   
                    if (n != numero)
                    {
                        --oportunidades;
                        if (oportunidades == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n ******************   Has perdido, lo siento   **********************\n\n");
                            Console.Write("\n\n\n(1) Para salir   -   (2) Para volver a jugar = ");
                            int opciones = Convert.ToInt32(Console.ReadLine());
                            opcion = (opciones == 2) ? true : false;
                        }
                        else
                        {
                            Console.WriteLine("\n\n ******************    INCORRECTO !!!! Intentalo otra vez mientras puedas....\n\n");
                            Console.WriteLine(">>>>>>>>>>>  Presiona ENTER para continuar >>>");
                            Console.ReadKey();
                        }      
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n      OPORTUNIDADES = {0}            NUMERO SECRETO = {1}\n\n", oportunidades, numero);
                        oportunidades = 0;
                        Console.WriteLine("\n\n¡¡¡¡¡      FELICITACIONES, HAS ACERTADO  !!!!!!!! El numero es {0} !!!!!!\n\n", numero);
                        Console.Write("\n\n\n(1) Para salir   -   (2) Para volver a jugar = ");
                        int opciones = Convert.ToInt32(Console.ReadLine());
                        opcion = (opciones == 2) ? true : false;
                    }   
                } while (oportunidades != 0);   
            } while (opcion);   
        }
    }
}
