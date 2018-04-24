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
    public partial class frmMaiorValorDeTres : Form
    {
        public frmMaiorValorDeTres()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double valora = System.Convert.ToDouble(txbValorA.Text);
            double valorb = System.Convert.ToDouble(txbValorB.Text);
            double valorc = System.Convert.ToDouble(txbValorC.Text);

            if(valora > valorb && valora > valorc)
            {
                lblResposta.Text = "O maior valor é A";
            }
            if (valorb > valora && valorb > valorc)
            {
                lblResposta.Text = "O maior valor é B";
            }
            if (valorc > valora && valorc > valorb)
            {
                lblResposta.Text = "O maior valor é C";
            }
            if (valora == valorb && valora == valorc)
            {
                lblResposta.Text = "Todos os valores são iguais.";
            }
            if (valora > valorb && valora == valorc)
            {
                lblResposta.Text = "O maior valor é A e C";
            }
            if (valora > valorc && valora == valorb)
            {
                lblResposta.Text = "O maior valor é A e B";
            }
            if (valorb > valora && valorb == valorc)
            {
                lblResposta.Text = "O maior valor é B e C";
            }
        }
    }
}
