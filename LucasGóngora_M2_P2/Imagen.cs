using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasGóngora_M2_P2
{
    class Imagen
    {
        public void Apariencia()
        {
            Console.Write("\n\nPor favor, ingrese la altura: ");
            int altura = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nPor favor, ingrese el ancho: ");
            int ancho = Convert.ToInt32(Console.ReadLine());
            if(altura > ancho && altura != ancho)
            {
                Console.WriteLine("\n\nLa imagen es vertical");
            }else if(altura < ancho && altura != ancho)
            {
                Console.WriteLine("\n\nLa imagen es horizaontal");
            }else { Console.WriteLine("\n\nLa imagen es cuadrada"); }
        }
    }
}
