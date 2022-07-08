using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorQuark.Modelos
{
    internal class Cotizacion
    {
        public string vendedorId { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public Prenda PrendaCotizada { get; set; }
        public int CantCotizada { get; set; }
        public double Resultado { get; set; }
        public Cotizacion(Prenda prenda, int cantidad, string vendedor)
        {
            vendedorId = vendedor;
            Fecha = DateTime.Now;
            Hora = DateTime.Now;
            PrendaCotizada = prenda;
            CantCotizada = cantidad;
            Resultado = prenda.Precio * cantidad;
        }

    }
}
