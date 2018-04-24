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
    public partial class frmMedia : Form
    {
        public frmMedia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1 = System.Convert.ToDouble(txb1Bim.Text);
            double nota2 = System.Convert.ToDouble(txb2Bim.Text);
            double nota3 = System.Convert.ToDouble(txb3Bim.Text);
            double nota4 = System.Convert.ToDouble(txb4Bim.Text);

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            lblMedia.Text = media.ToString();
            lblNome.Text = txbNome.Text;
        }
    }
}
