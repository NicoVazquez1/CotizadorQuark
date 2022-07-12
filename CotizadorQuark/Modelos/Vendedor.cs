using CotizadorQuark.Repositorios;
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
        public static int Id { get; set; }
        public List<Cotizacion> Cotizaciones;
        public Vendedor(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            Id = 001001;
            Cotizaciones = new List<Cotizacion>();
            Id++;
        }
        public List<Cotizacion> agregarCotizacion(List<Cotizacion> cotizaciones)
        {
            cotizaciones.ForEach(element => Cotizaciones.Add(element));
            return Cotizaciones;
        }
    }
}
