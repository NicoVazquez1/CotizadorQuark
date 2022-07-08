using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorQuark.Controladores
{
    internal class Controller
    {
        string info;
        public string Cotizar(Form1 form)
        {
            if (form.radioButtonCamisa.Checked)
            {
                info = "camisa";
                if (form.checkBox_cMao.Checked)
                {
                    info += " | cuello mao";
                }
                else
                {
                    info += " | cuello común";
                }
                if (form.checkBox_mCorta.Checked)
                {
                    info += " | manga corta";
                }
                else
                {
                    info += " | manga larga";
                }
            }
            if (form.radioButtonPantalon.Checked)
            {
                info = "pantalón";
                if (form.checkBoxChupin.Checked)
                {
                    info += " | chupín";
                }
                else
                {
                    info += " | común";
                }
            }
            if (form.radioButtonPremium.Checked)
            {
                info += " | premium";
            }
            else
            {
                info += " | standar";
            }
            
            return info;
            
            //if if ( form.algo.checked ) Tienda<Prendas>.FilterBy(algo)
            //if (algo.cant?) => algo.Precio;
        }
    }
}
