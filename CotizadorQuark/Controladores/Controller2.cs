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
        public Vendedor GetVendedor()
        {
            var vendedor = VendedorRepository.Instancia.GetVendedor("Juan");
            return vendedor;
        }

        public void MostrarCotizaciones(Vendedor vendedor, Form2 form)
        {
            vendedor.Cotizaciones.ForEach(cotizacion =>
            {
                string info = $"{cotizacion.PrendaCotizada.GetType().Name} |                      " +
                $" {cotizacion.PrendaCotizada.EsPremium.ToString()} | {cotizacion.Fecha.ToString("yyyy-MM-dd")} |" +
                $" {cotizacion.Hora.ToString("HH:mm")} | {cotizacion.CantCotizada.ToString()} |" +
                $" {cotizacion.Resultado.ToString()}  ";
                form.listBoxCotizaciones.Items.Add(info);
            });
            form.label_totalCotizado.Text = vendedor.Cotizaciones.Sum(cotizacion => cotizacion.Resultado).ToString();
        }

        public void MostrarDatos(Form2 form)
        {
            Tienda<Prenda> tienda = Tienda<Prenda>.Instancia;
            Vendedor vendedor = GetVendedor();
            form.labelNombreTienda.Text = tienda.Nombre.ToString();
            form.labelDireccion.Text = tienda.Direccion.ToString();
            form.labelVendedorInfo.Text = vendedor.Nombre.ToString() + " " + vendedor.Apellido.ToString() + " | " + Vendedor.Id.ToString();
        }

    }
}
