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
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        Boolean btnPress = false;

        private void Numeros_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if ((txbResultado.Text == "0"))
            {
                txbResultado.Text = btn.Text;
                btnPress = false;
            }
            else
            {
                txbResultado.Text += btn.Text;
                btnPress = false;
            }
        }

        private void Operacao_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btnPress == false)
            {
                txbResultado.Text += btn.Text;
                btnPress = true;
            }
            else if (btnPress == true)
            {
                int tamanhostring = txbResultado.Text.Length;

                txbResultado.Text = txbResultado.Text.Remove(tamanhostring - 1);
                txbResultado.Text += btn.Text;
                btnPress = true;
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int replacetexto = 0;

            string texto = txbResultado.Text;
            int tamanhotexto = texto.Length;

            if (texto.Substring(0, 1) == "-") 
            {
                texto = texto.Remove(0, 1);
                replacetexto = 1;
            }

            if (texto.Substring(tamanhotexto - 1) == "+" || texto.Substring(tamanhotexto - 1) == "-" || texto.Substring(tamanhotexto - 1) == "/" || texto.Substring(tamanhotexto - 1) == "*")
            {
                texto = texto.Remove(tamanhotexto-1);
                btnPress = false;
            }

            string[] numeros = texto.Split('+', '-', '/', '*');
            int tamanhonumero = numeros.Length;
            string[] sinal = new string[tamanhonumero];

            int aux = 0;
            for (int variavel = 0; variavel < (tamanhonumero - 1); variavel++)
            {
                int tamnum = numeros[variavel].Length;
                aux = aux + tamnum;
                sinal[variavel] = texto.Substring(aux, 1);
                aux++;
            }
            int tamanhosinais = sinal.Length;

            double resultado = 0;
            int aux2 = 0;

            if (replacetexto == 1)
            {
                resultado = Convert.ToDouble(numeros[0]);
                resultado = resultado * (-1);
            }
            else
            {
                resultado = Convert.ToDouble(numeros[0]);
            }
            for (int soma = 0; soma < tamanhosinais; soma++)
            {
                while (aux2 < (tamanhosinais - 1))
                {
                    double resultado1 = Convert.ToDouble(numeros[aux2 + 1]);
                    switch (sinal[aux2])
                    {
                        case "+" : resultado += resultado1; break;
                        case "-" : resultado -= resultado1; break;
                        case "*" : resultado *= resultado1; break;
                        case "/" : resultado /= resultado1; break;
                    }
                    aux2++;
                }
            }
            txbResultado.Text = resultado.ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "0";
            btnPress = false;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text.Length != 1)
            {
                txbResultado.Text = (txbResultado.Text.Substring(0, txbResultado.Text.Length - 1));
                btnPress = false;
            }
            else txbResultado.Text = ("0");
        }

        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            int[] achar = new int[4];
            achar[0] = txbResultado.Text.IndexOf("+");
            achar[1] = txbResultado.Text.IndexOf("-");
            achar[2] = txbResultado.Text.IndexOf("*");
            achar[3] = txbResultado.Text.IndexOf("/");

            if (achar[0] >= 1 || achar[1] >= 1 || achar[2] >= 1 || achar[3] >= 1) { }
            else 
            {
                double resultmaismenos = Convert.ToDouble(txbResultado.Text) * (-1);
                txbResultado.Text = resultmaismenos.ToString();
            }
        }
    }
}
