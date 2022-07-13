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
        public Vendedor GetDatosVendedor() {
            var vendedor = VendedorRepository.Instancia.GetVendedor("Juan");
            return vendedor;
        }
        public void Iniciar()
        {
            Tienda<Prenda>.Instancia.crearStock();
        }

        public void Cotizar(Form1 form)
        {
            Tienda<Prenda> tienda = Tienda<Prenda>.Instancia;
            bool esCamisa = form.radioButtonCamisa.Checked;
            bool esMangaCrt = form.checkBox_mCorta.Checked;
            bool esCuelloMao = form.checkBox_cMao.Checked;
            bool esChupin = form.checkBoxChupin.Checked;
            bool esPremium = form.radioButtonPremium.Checked;
            var precio = Convert.ToDouble(form.textBoxPrecio.Text);
            var cantidad = Convert.ToInt32(form.textBoxCantidad.Text);
            var total = precio * cantidad;

            if (esCamisa)
            {
                try
                {
                    var camisa = tienda.camisas.FirstOrDefault(c => c.EsCuelloMao == esCuelloMao && c.EsMangaCort == esMangaCrt &&
                    c.Cantidad >= cantidad);
                    camisa.ValidarPrecio(precio);
                    tienda.ActualizarLista(camisa, cantidad);
                    GetDatosVendedor().AgregarCotizacion(camisa, cantidad);
                    form.label_resultado.Text = total.ToString();
                    form.label_nStock.Text = camisa.Cantidad.ToString();
                    MessageBox.Show("Cotizacion realizada con exito");
                }
                catch (Exception)
                {
                    throw new Exception("No hay camisas disponibles");
                }
            }
            else
            {
                try
                {
                    var pantalon = tienda.pantalones.FirstOrDefault(p => p.EsPremium == esPremium && p.EsChupin == esChupin && 
                    p.Cantidad >= cantidad);
                    pantalon.ValidarPrecio(precio);
                    tienda.ActualizarLista(pantalon, cantidad);
                    GetDatosVendedor().AgregarCotizacion(pantalon, cantidad);
                    form.label_resultado.Text = total.ToString();
                    form.label_nStock.Text = pantalon.Cantidad.ToString();
                    MessageBox.Show("Cotizacion realizada con exito");
                }
                catch (Exception)
                {
                    throw new Exception("No hay pantalones disponibles");
                }
            }
        }
    }
}
