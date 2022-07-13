using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CotizadorQuark.Properties;
using CotizadorQuark.Repositorios;
using CotizadorQuark.Modelos;

namespace CotizadorQuark.Controladores
{
    internal class Controller
    {
        public Vendedor GetVendedor() {
            var vendedor = VendedorRepository.Instancia.GetVendedor("Juan");
            return vendedor;
        }
        public void Iniciar()
        {
            Tienda<Prenda>.Instancia.CrearStock();
        }
        public void Cotizar(Form1 form)
        {
            Tienda<Prenda> tienda = Tienda<Prenda>.Instancia;
            bool esCamisa = form.radioButtonCamisa.Checked;
            bool esMangaCrt = form.checkBox_mCorta.Checked;
            bool esCuelloMao = form.checkBox_cMao.Checked;
            bool esChupin = form.checkBoxChupin.Checked;
            bool esPremium = form.radioButtonPremium.Checked;
            double precio;
            int cantidad;
            double total;
            try
            {
                precio = Convert.ToDouble(form.textBoxPrecio.Text);
                cantidad = Convert.ToInt32(form.textBoxCantidad.Text);
                if (esCamisa)
                {
                    try
                    {
                        var camisa = tienda.camisas.FirstOrDefault(c => c.EsPremium == esPremium && c.EsCuelloMao == esCuelloMao && c.EsMangaCort == esMangaCrt &&
                        c.Cantidad >= cantidad);
                        total = camisa.ValidarPrecio(precio);
                        tienda.ActualizarLista(camisa, cantidad);
                        GetVendedor().AgregarCotizacion(camisa, cantidad);
                        form.label_nStock.Text = camisa.Cantidad.ToString();
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("No hay suficientes prendas en stock");
                    }
                }
                else
                {
                    try
                    {
                        var pantalon = tienda.pantalones.FirstOrDefault(p => p.EsPremium == esPremium && p.EsChupin == esChupin &&
                        p.Cantidad >= cantidad);
                        total = pantalon.ValidarPrecio(precio);
                        tienda.ActualizarLista(pantalon, cantidad);
                        GetVendedor().AgregarCotizacion(pantalon, cantidad);
                        form.label_nStock.Text = pantalon.Cantidad.ToString();
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("No hay suficientes prendas en stock");
                    }
                }
                total = GetVendedor().Cotizaciones.Last().Resultado;
                Math.Floor(total);
                form.label_resultado.Text = total.ToString();
                MessageBox.Show("Cotizacion realizada con exito");
            }
            catch (FormatException)
            {
                MessageBox.Show("El precio debe ser un numero");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        public void MostrarDatos(Form1 form)
        {
            Tienda<Prenda> tienda = Tienda<Prenda>.Instancia;
            Vendedor vendedor = GetVendedor();
            form.labelNombreTienda.Text = tienda.Nombre.ToString();
            form.labelDireccion.Text = tienda.Direccion.ToString();
            form.labelVendedorInfo.Text = vendedor.Nombre.ToString() + " " + vendedor.Apellido.ToString() + " | " + Vendedor.Id.ToString();
        }
    }

    
}
