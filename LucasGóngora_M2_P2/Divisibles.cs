using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasGóngora_M2_P2
{
    class Divisibles
    {
        public void Tres()
        {
            Console.WriteLine("\n\n¿Cuantos numeros son divisibles por 3?");
            for(int i=1; i<=150; i++)
            {
                if (i%3 == 0)
                {
                    Console.WriteLine(i);    
                }
            }
        }
    }
}
