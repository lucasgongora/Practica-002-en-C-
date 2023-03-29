using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasGóngora_M2_P2
{
    class Diez
    {
        public void Numeros()
        {
            try
            {
                Console.Write("\n\nPor favor, ingrese un numero entre 1 y 10: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero >= 1 && numero <= 10)
                {
                    Console.WriteLine("\n\nEl numero es correcto");
                }
                else
                {
                    Console.WriteLine("\n\nEl numero no es correcto");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\n\nHas ingresado una letra en lugar de un numero, vuelve a intentarlo.");
            }
        }
    }
}
