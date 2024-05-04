using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPrestamo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(TxtMonto.Text);
            double interes = double.Parse(TxtInteres.Text);
            double plazo = double.Parse(TxtPlazo.Text);
            double interesMensual = interes / 12 / 100;

            double Cuota = (monto * interes) / (1 - Math.Pow(1 + interesMensual, -plazo * 12));

            LblResultado.Text = $" La cuota es de: {Cuota} ";
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtInteres.Clear();
            TxtMonto.Clear();
            TxtPlazo.Clear();
            TxtMensual.Clear();
            LblResultado.Text = string.Empty;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
