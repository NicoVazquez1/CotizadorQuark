namespace CotizadorQuark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCamisa.Checked)
            {
                checkBoxChupin.Enabled = false;
            }
            else
            {
                checkBoxChupin.Enabled = true;
            }
        }

        private void radioButtonPantalon_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPantalon.Checked)
            {
                checkBox_cMao.Enabled = false;
                checkBox_mCorta.Enabled = false;
            }
            else
            {
                checkBox_cMao.Enabled = true;
                checkBox_mCorta.Enabled = true;
            }
        }

        private void buttonCotizar_Click(object sender, EventArgs e)
        {
            string info;
            Controladores.Controller cotizador = new Controladores.Controller();
            info = cotizador.Cotizar(this);
            MessageBox.Show(info);
        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}