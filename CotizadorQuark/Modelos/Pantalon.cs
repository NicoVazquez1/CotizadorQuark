using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorQuark.Modelos
{
    internal class Pantalon : Prenda
    {
        bool EsChupin { get; set; }
        public Pantalon(double precio, bool esPremium, bool esChupin) : base(precio, esPremium)
        {
            //Extraer las RN a otra clase
            EsChupin = esChupin;
            if (EsChupin)
            {
                precio *= 0.88;
            }
            Precio = precio;
        }
    }
}
