using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorQuark.Modelos
{
    internal class Vendedor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Id { get; set; }
        public List<Cotizacion> Cotizaciones;
        public Tienda Tienda { get; set; }
        public Vendedor(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            Id = Guid.NewGuid().ToString();
            Cotizaciones = new List<Cotizacion>();
        }
        public List<Cotizacion> agregarCotizacion(List<Cotizacion> cotizaciones)
        {
            cotizaciones.ForEach(element => Cotizaciones.Add(element));
            return Cotizaciones;
        }
    }
}
