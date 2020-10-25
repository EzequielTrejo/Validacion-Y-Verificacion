using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    public class Cuentas
    {
        public decimal Suma(int cantidad, decimal precio)
        {
            decimal Total = 0;
            Total = Total + precio * cantidad;
            return Total;
        }
    }
}
