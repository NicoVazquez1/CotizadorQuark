namespace CotizadorQuark
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCotizadorExpress = new System.Windows.Forms.Label();
            this.labelVendedorInfo = new System.Windows.Forms.Label();
            this.labelNombreTienda = new System.Windows.Forms.Label();
            this.labelHistorialCotizaciones = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.label_nStock = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.label_simbolitoRes = new System.Windows.Forms.Label();
            this.label_simbolito = new System.Windows.Forms.Label();
            this.label_resultado = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.radioButtonCamisa = new System.Windows.Forms.RadioButton();
            this.radioButtonPantalon = new System.Windows.Forms.RadioButton();
            this.radioButtonStandar = new System.Windows.Forms.RadioButton();
            this.radioButtonPremium = new System.Windows.Forms.RadioButton();
            this.checkBoxChupin = new System.Windows.Forms.CheckBox();
            this.checkBox_mCorta = new System.Windows.Forms.CheckBox();
            this.checkBox_cMao = new System.Windows.Forms.CheckBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.buttonCotizar = new System.Windows.Forms.Button();
            this.groupBox_PrendaTipo = new System.Windows.Forms.GroupBox();
            this.groupBoxCalidad = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_precioUnidad = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox_PrendaTipo.SuspendLayout();
            this.groupBoxCalidad.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_precioUnidad.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCotizadorExpress
            // 
            this.labelCotizadorExpress.AutoSize = true;
            this.labelCotizadorExpress.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCotizadorExpress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCotizadorExpress.Location = new System.Drawing.Point(173, 17);
            this.labelCotizadorExpress.Name = "labelCotizadorExpress";
            this.labelCotizadorExpress.Size = new System.Drawing.Size(198, 26);
            this.labelCotizadorExpress.TabIndex = 0;
            this.labelCotizadorExpress.Text = "Cotizador Express";
            // 
            // labelVendedorInfo
            // 
            this.labelVendedorInfo.AutoSize = true;
            this.labelVendedorInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVendedorInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelVendedorInfo.Location = new System.Drawing.Point(35, 116);
            this.labelVendedorInfo.Name = "labelVendedorInfo";
            this.labelVendedorInfo.Size = new System.Drawing.Size(265, 15);
            this.labelVendedorInfo.TabIndex = 1;
            this.labelVendedorInfo.Text = "Nombre y Aprellido Vendedor | Código Vendedor";
            // 
            // labelNombreTienda
            // 
            this.labelNombreTienda.AutoSize = true;
            this.labelNombreTienda.Location = new System.Drawing.Point(35, 88);
            this.labelNombreTienda.Name = "labelNombreTienda";
            this.labelNombreTienda.Size = new System.Drawing.Size(89, 15);
            this.labelNombreTienda.TabIndex = 3;
            this.labelNombreTienda.Text = "Nombre Tienda";
            // 
            // labelHistorialCotizaciones
            // 
            this.labelHistorialCotizaciones.AutoSize = true;
            this.labelHistorialCotizaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelHistorialCotizaciones.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelHistorialCotizaciones.Location = new System.Drawing.Point(390, 116);
            this.labelHistorialCotizaciones.Name = "labelHistorialCotizaciones";
            this.labelHistorialCotizaciones.Size = new System.Drawing.Size(124, 15);
            this.labelHistorialCotizaciones.TabIndex = 4;
            this.labelHistorialCotizaciones.Text = "Historial Cotizaciones ";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(11, 28);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(169, 15);
            this.labelStock.TabIndex = 11;
            this.labelStock.Text = "Unidades de stock disponibles:";
            // 
            // label_nStock
            // 
            this.label_nStock.AutoSize = true;
            this.label_nStock.Location = new System.Drawing.Point(186, 28);
            this.label_nStock.Name = "label_nStock";
            this.label_nStock.Size = new System.Drawing.Size(57, 15);
            this.label_nStock.TabIndex = 12;
            this.label_nStock.Text = "__________";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(94, 24);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(55, 15);
            this.labelCantidad.TabIndex = 17;
            this.labelCantidad.Text = "Cantidad";
            // 
            // label_simbolitoRes
            // 
            this.label_simbolitoRes.AutoSize = true;
            this.label_simbolitoRes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_simbolitoRes.Location = new System.Drawing.Point(264, 21);
            this.label_simbolitoRes.Name = "label_simbolitoRes";
            this.label_simbolitoRes.Size = new System.Drawing.Size(13, 15);
            this.label_simbolitoRes.TabIndex = 18;
            this.label_simbolitoRes.Text = "$";
            // 
            // label_simbolito
            // 
            this.label_simbolito.AutoSize = true;
            this.label_simbolito.Location = new System.Drawing.Point(6, 26);
            this.label_simbolito.Name = "label_simbolito";
            this.label_simbolito.Size = new System.Drawing.Size(13, 15);
            this.label_simbolito.TabIndex = 19;
            this.label_simbolito.Text = "$";
            // 
            // label_resultado
            // 
            this.label_resultado.AutoSize = true;
            this.label_resultado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_resultado.Location = new System.Drawing.Point(283, 21);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(72, 15);
            this.label_resultado.TabIndex = 20;
            this.label_resultado.Text = "_____________";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(391, 90);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(123, 15);
            this.labelDireccion.TabIndex = 21;
            this.labelDireccion.Text = "Dirección de la Tienda";
            // 
            // radioButtonCamisa
            // 
            this.radioButtonCamisa.AutoSize = true;
            this.radioButtonCamisa.Location = new System.Drawing.Point(18, 22);
            this.radioButtonCamisa.Name = "radioButtonCamisa";
            this.radioButtonCamisa.Size = new System.Drawing.Size(64, 19);
            this.radioButtonCamisa.TabIndex = 22;
            this.radioButtonCamisa.TabStop = true;
            this.radioButtonCamisa.Text = "Camisa";
            this.radioButtonCamisa.UseVisualStyleBackColor = true;
            this.radioButtonCamisa.CheckedChanged += new System.EventHandler(this.radioButtonCamisa_CheckedChanged);
            // 
            // radioButtonPantalon
            // 
            this.radioButtonPantalon.AutoSize = true;
            this.radioButtonPantalon.Location = new System.Drawing.Point(18, 57);
            this.radioButtonPantalon.Name = "radioButtonPantalon";
            this.radioButtonPantalon.Size = new System.Drawing.Size(72, 19);
            this.radioButtonPantalon.TabIndex = 23;
            this.radioButtonPantalon.TabStop = true;
            this.radioButtonPantalon.Text = "Pantalón";
            this.radioButtonPantalon.UseVisualStyleBackColor = true;
            this.radioButtonPantalon.CheckedChanged += new System.EventHandler(this.radioButtonPantalon_CheckedChanged);
            // 
            // radioButtonStandar
            // 
            this.radioButtonStandar.AutoSize = true;
            this.radioButtonStandar.Location = new System.Drawing.Point(6, 22);
            this.radioButtonStandar.Name = "radioButtonStandar";
            this.radioButtonStandar.Size = new System.Drawing.Size(65, 19);
            this.radioButtonStandar.TabIndex = 24;
            this.radioButtonStandar.TabStop = true;
            this.radioButtonStandar.Text = "Standar";
            this.radioButtonStandar.UseVisualStyleBackColor = true;
            // 
            // radioButtonPremium
            // 
            this.radioButtonPremium.AutoSize = true;
            this.radioButtonPremium.Location = new System.Drawing.Point(96, 22);
            this.radioButtonPremium.Name = "radioButtonPremium";
            this.radioButtonPremium.Size = new System.Drawing.Size(74, 19);
            this.radioButtonPremium.TabIndex = 25;
            this.radioButtonPremium.TabStop = true;
            this.radioButtonPremium.Text = "Premium";
            this.radioButtonPremium.UseVisualStyleBackColor = true;
            // 
            // checkBoxChupin
            // 
            this.checkBoxChupin.AutoSize = true;
            this.checkBoxChupin.Location = new System.Drawing.Point(213, 58);
            this.checkBoxChupin.Name = "checkBoxChupin";
            this.checkBoxChupin.Size = new System.Drawing.Size(65, 19);
            this.checkBoxChupin.TabIndex = 26;
            this.checkBoxChupin.Text = "Chupín";
            this.checkBoxChupin.UseVisualStyleBackColor = true;
            // 
            // checkBox_mCorta
            // 
            this.checkBox_mCorta.AutoSize = true;
            this.checkBox_mCorta.Location = new System.Drawing.Point(213, 22);
            this.checkBox_mCorta.Name = "checkBox_mCorta";
            this.checkBox_mCorta.Size = new System.Drawing.Size(93, 19);
            this.checkBox_mCorta.TabIndex = 27;
            this.checkBox_mCorta.Text = "Manga corta";
            this.checkBox_mCorta.UseVisualStyleBackColor = true;
            // 
            // checkBox_cMao
            // 
            this.checkBox_cMao.AutoSize = true;
            this.checkBox_cMao.Location = new System.Drawing.Point(327, 22);
            this.checkBox_cMao.Name = "checkBox_cMao";
            this.checkBox_cMao.Size = new System.Drawing.Size(87, 19);
            this.checkBox_cMao.TabIndex = 28;
            this.checkBox_cMao.Text = "Cuello mao";
            this.checkBox_cMao.UseVisualStyleBackColor = true;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(25, 22);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(43, 23);
            this.textBoxPrecio.TabIndex = 29;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(153, 21);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(43, 23);
            this.textBoxCantidad.TabIndex = 30;
            this.textBoxCantidad.TextChanged += new System.EventHandler(this.textBoxCantidad_TextChanged);
            // 
            // buttonCotizar
            // 
            this.buttonCotizar.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonCotizar.Location = new System.Drawing.Point(115, 13);
            this.buttonCotizar.Name = "buttonCotizar";
            this.buttonCotizar.Size = new System.Drawing.Size(120, 30);
            this.buttonCotizar.TabIndex = 31;
            this.buttonCotizar.Text = "Cotizar";
            this.buttonCotizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonCotizar.UseVisualStyleBackColor = false;
            this.buttonCotizar.Click += new System.EventHandler(this.buttonCotizar_Click);
            // 
            // groupBox_PrendaTipo
            // 
            this.groupBox_PrendaTipo.Controls.Add(this.checkBox_mCorta);
            this.groupBox_PrendaTipo.Controls.Add(this.checkBox_cMao);
            this.groupBox_PrendaTipo.Controls.Add(this.radioButtonCamisa);
            this.groupBox_PrendaTipo.Controls.Add(this.radioButtonPantalon);
            this.groupBox_PrendaTipo.Controls.Add(this.checkBoxChupin);
            this.groupBox_PrendaTipo.Location = new System.Drawing.Point(63, 151);
            this.groupBox_PrendaTipo.Name = "groupBox_PrendaTipo";
            this.groupBox_PrendaTipo.Size = new System.Drawing.Size(445, 96);
            this.groupBox_PrendaTipo.TabIndex = 32;
            this.groupBox_PrendaTipo.TabStop = false;
            this.groupBox_PrendaTipo.Text = "Prenda";
            // 
            // groupBoxCalidad
            // 
            this.groupBoxCalidad.Controls.Add(this.radioButtonStandar);
            this.groupBoxCalidad.Controls.Add(this.radioButtonPremium);
            this.groupBoxCalidad.Location = new System.Drawing.Point(63, 333);
            this.groupBoxCalidad.Name = "groupBoxCalidad";
            this.groupBoxCalidad.Size = new System.Drawing.Size(212, 65);
            this.groupBoxCalidad.TabIndex = 33;
            this.groupBoxCalidad.TabStop = false;
            this.groupBoxCalidad.Text = "Calidad de Prenda";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_nStock);
            this.groupBox1.Controls.Add(this.labelStock);
            this.groupBox1.Location = new System.Drawing.Point(63, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 61);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // groupBox_precioUnidad
            // 
            this.groupBox_precioUnidad.Controls.Add(this.label_simbolito);
            this.groupBox_precioUnidad.Controls.Add(this.textBoxPrecio);
            this.groupBox_precioUnidad.Controls.Add(this.labelCantidad);
            this.groupBox_precioUnidad.Controls.Add(this.textBoxCantidad);
            this.groupBox_precioUnidad.Location = new System.Drawing.Point(281, 333);
            this.groupBox_precioUnidad.Name = "groupBox_precioUnidad";
            this.groupBox_precioUnidad.Size = new System.Drawing.Size(227, 65);
            this.groupBox_precioUnidad.TabIndex = 35;
            this.groupBox_precioUnidad.TabStop = false;
            this.groupBox_precioUnidad.Text = "Precio unitario y Cantidad";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCotizar);
            this.panel1.Controls.Add(this.label_simbolitoRes);
            this.panel1.Controls.Add(this.label_resultado);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(-2, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 100);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BlueViolet;
            this.panel2.Controls.Add(this.labelCotizadorExpress);
            this.panel2.Location = new System.Drawing.Point(-2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 63);
            this.panel2.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_precioUnidad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCalidad);
            this.Controls.Add(this.groupBox_PrendaTipo);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelHistorialCotizaciones);
            this.Controls.Add(this.labelNombreTienda);
            this.Controls.Add(this.labelVendedorInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_PrendaTipo.ResumeLayout(false);
            this.groupBox_PrendaTipo.PerformLayout();
            this.groupBoxCalidad.ResumeLayout(false);
            this.groupBoxCalidad.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_precioUnidad.ResumeLayout(false);
            this.groupBox_precioUnidad.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelCotizadorExpress;
        private Label labelVendedorInfo;
        private Label labelNombreTienda;
        private Label labelHistorialCotizaciones;
        public Label labelStock;
        public Label label_nStock;
        private Label labelCantidad;
        private Label label_simbolitoRes;
        private Label label_simbolito;
        public Label label_resultado;
        private Label labelDireccion;
        public RadioButton radioButtonCamisa;
        public RadioButton radioButtonPantalon;
        public RadioButton radioButtonStandar;
        public RadioButton radioButtonPremium;
        public CheckBox checkBoxChupin;
        public CheckBox checkBox_mCorta;
        public CheckBox checkBox_cMao;
        public TextBox textBoxPrecio;
        public TextBox textBoxCantidad;
        private Button buttonCotizar;
        private GroupBox groupBox_PrendaTipo;
        private GroupBox groupBoxCalidad;
        private GroupBox groupBox1;
        private GroupBox groupBox_precioUnidad;
        private Panel panel1;
        private Panel panel2;
    }
}