using System;
using System.Data;
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
            Total = Total + precio / cantidad;
            return Total;
        }

        public decimal ResultadoFinal(DataTable Productos)
        {
            decimal Resultado = 0;
            for(int i = 0; i < Productos.Rows.Count; i+=2)
            {
                try
                {
                    Resultado = Convert.ToDecimal(Productos.Rows[i]["Total"]) + Convert.ToDecimal(Productos.Rows[i + 1]["Total"]);
                }
                catch(Exception)
                {
                    Resultado = Resultado + Convert.ToDecimal(Productos.Rows[i]["Total"]);
                }
            }
            return Resultado;
        }

    }
}
