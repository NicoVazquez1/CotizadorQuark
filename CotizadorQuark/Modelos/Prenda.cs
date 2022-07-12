using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorQuark.Modelos
{
    internal abstract class Prenda
    {
        private double precio;
        public double Precio 
        { 
            get { return this.precio; }
            set { this.precio = ValidarPrecio(value); } 
        }
        public bool EsPremium { get; set; }
        public int Cantidad { get; set; }
        public Prenda(bool esPremium, int cantidad)
        {
            //Extraer las RN a otra clase
            EsPremium = esPremium;
            Cantidad = cantidad;
        }
        public double ValidarPrecio(double precio)
        {
            if (Precio < 0)
            {
                throw new Exception("El precio no puede ser negativo");
            }
            if (EsPremium)
            {
                precio *= 1.3;
            }
            return Precio;
        }

    }
}
