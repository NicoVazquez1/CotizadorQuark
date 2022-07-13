using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorQuark.Modelos
{
    internal class Pantalon : Prenda
    {
        public bool EsChupin { get; set; }
        public Pantalon(bool esPremium, bool esChupin, int cantidad) : base(esPremium, cantidad)
        {
            EsChupin = esChupin;
        }
        public new double ValidarPrecio(double precio)
        {
            base.ValidarPrecio(precio);
            if (EsChupin)
            {
                precio *= 0.88;
            }
            return Precio = precio;
        }
    }
}
