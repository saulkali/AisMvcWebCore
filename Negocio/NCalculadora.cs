using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NCalculadora
    {
        public int Factorial(int numero)
        {
            int resultado = 1;
            for (int counter = 1; counter <= numero; counter++)
            {
                resultado *= counter;
            }
            return resultado;
        }
    }
}
