using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasGóngora_M2_P2
{
    class Multisuma
    {
        
        public void Detener()
        {
            bool A = true; 
            int suma = 0;
            Console.WriteLine("\n\nIngrese todos los numeros que quiera sumar.\n" +
                "Ingrese SUMA para mostrar el resultado y SALIR para cerrar la funcion.\n");
            while (A)
            {
                Console.Write("\n\nIngrese Numero = ");
                string numero = Console.ReadLine();
                numero = numero.ToUpper();
                
                if (numero == "SUMA")
                {
                    Console.WriteLine("\n\nResultado total = " + suma);
                    A = false;
                }else if (numero == "SALIR")
                {
                    A = false;
                }
                else { suma = suma + (Convert.ToInt32(numero)); }
            }
        }
    }
}
