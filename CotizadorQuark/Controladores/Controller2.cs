using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CotizadorQuark.Repositorios;
using CotizadorQuark.Modelos;


namespace CotizadorQuark.Controladores
{
    internal class Controller2
    {
        public Vendedor GetVenderdor()
        {
            var vendedor = VendedorRepository.Instancia.GetVendedor("Juan");
            return vendedor;
        }

        public void MostrarCotizaciones(Vendedor vendedor, Form2 form)
        {
            Cotizacion cotizacion = vendedor.GetCotizacion();
            form.labeltipoPrendac.Text = cotizacion.PrendaCotizada.GetType().Name;
            form.labelPremiumc.Text = cotizacion.PrendaCotizada.EsPremium.ToString();
            form.labelFecha.Text = cotizacion.Fecha.ToString("yyyy-MM-dd");
            form.labelHora.Text = cotizacion.Hora.ToString("HH:mm");
            form.labelCantidadc.Text = cotizacion.CantCotizada.ToString();
            form.labelCotizacionc.Text = cotizacion.Resultado.ToString();
            form.label_totalCotizado.Text = vendedor.TotaldeCotizaciones.ToString();
        }
        
    }
}
