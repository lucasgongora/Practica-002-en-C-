using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasGóngora_M2_P2
{
    class Cafe
    {
        public void Temperatura()
        {
            Console.Write("\n\nPor favor, ingrese la tempreratura del café: ");
            int temperatura = Convert.ToInt32(Console.ReadLine());
            if (temperatura < 20)
            {
                Console.WriteLine("\n\nEl café está frio");
            }
            else if (temperatura >= 20 && temperatura <= 60)
            {
                Console.WriteLine("\n\nEl café está caliente");
            }
            else { Console.WriteLine("\n\nTe quemarás con el café, debes esperar 10 minutos para beberlo"); }
        }
    }
}
