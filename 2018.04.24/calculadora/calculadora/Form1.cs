using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double dnum1 = System.Convert.ToDouble(txbValor1.Text);
            double dnum2 = System.Convert.ToDouble(txbValor2.Text);
            double soma = dnum1 + dnum2;

            lblResultado.Text = soma.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double dnum1 = System.Convert.ToDouble(txbValor1.Text);
            double dnum2 = System.Convert.ToDouble(txbValor2.Text);
            double soma = dnum1 - dnum2;

            lblResultado.Text = soma.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double dnum1 = System.Convert.ToDouble(txbValor1.Text);
            double dnum2 = System.Convert.ToDouble(txbValor2.Text);
            double soma = dnum1 * dnum2;

            lblResultado.Text = soma.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double dnum1 = System.Convert.ToDouble(txbValor1.Text);
            double dnum2 = System.Convert.ToDouble(txbValor2.Text);
            double soma = dnum1 / dnum2;

            lblResultado.Text = soma.ToString();
        }
    }
}
