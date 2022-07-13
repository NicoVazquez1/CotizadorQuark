using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorQuark.Modelos
{
    internal abstract class Prenda
    {
        public double Precio { get; set; }
        public bool EsPremium { get; set; }
        public int Cantidad { get; set; }
        public Prenda(bool esPremium, int cantidad)
        {
            EsPremium = esPremium;
            Cantidad = cantidad;
        }
        public double ValidarPrecio(double precio)
        {
            if (precio < 0)
            {
                MessageBox.Show("El precio no puede ser negativo");
                throw new ArgumentException("El precio no puede ser negativo");
            }
            if (EsPremium)
            {
                precio *= 1.3;
            }
            return precio;
        }

    }
}
