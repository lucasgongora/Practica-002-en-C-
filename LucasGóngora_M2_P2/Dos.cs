using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasGóngora_M2_P2
{
    class Dos
    {
        public void Suma()
        {
            try
            {
                Console.Write("\n\nPor favor, ingrese el primer numero: ");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n\nPor favor, ingrese el segundo numero: ");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                int suma = numero1 + numero2;
                Console.WriteLine("\n\n{0} + {1} = {2}", numero1, numero2, suma);
            }
            catch (Exception)
            {
                Console.WriteLine("\n\nHas ingresado una letra en lugar de un numero, vuelve a intentarlo.");
            }
        }
    }
}
