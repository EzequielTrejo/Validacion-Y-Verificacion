using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    public class Verificacion
    {
        public Boolean Validate(int Cantidad)
        {
            Boolean Res = false;
            if(Cantidad == 0)
            {
                return Res;
            }
            else
            {
                Res = true;
            }
            return Res;
        }
    }
}
