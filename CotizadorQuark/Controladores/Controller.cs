using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CotizadorQuark.Properties;

namespace CotizadorQuark.Controladores
{
    internal class Controller
    {
        public void Cotizar(Form1 form)
        {
            bool esMangaCrt;
            bool esCuelloMao;
            bool esChupin;
            bool esPremium;
            
            var precio = Convert.ToDouble(form.textBoxPrecio.Text);
            var cantidad = Convert.ToDouble(form.textBoxCantidad.Text);
            var total = precio * cantidad;

            if (form.radioButtonPremium.Checked)
            {
                esPremium = true;
            }
            if (form.radioButtonCamisa.Checked)
            {
                if (form.checkBox_cMao.Checked)
                {
                    esCuelloMao = true;
                }
                if (form.checkBox_mCorta.Checked)
                {
                    esMangaCrt = true;
                }
            }
            if (form.radioButtonPantalon.Checked)
            {
                if (form.checkBoxChupin.Checked)
                {
                    esChupin = true;
                }
            }
           
            
            //if if ( form.algo.checked ) Tienda<Prendas>.FilterBy(algo)
            //if (algo.cant?) => algo.Precio;
        }
    }
}
