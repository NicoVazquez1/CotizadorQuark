using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorQuark.Modelos
{
    internal abstract class Prenda
    {
        //public string  Nombre { get; set; }
        public double Precio { get; set; }
        public bool EsPremium { get; set; }
        public Prenda(double precio, bool esPremium)
        {
            //Extraer las RN a otra clase
            EsPremium = esPremium;
            if (EsPremium)
            {
                precio *= 1.3; //Chequear esto #1
            }
        }
    }
}
