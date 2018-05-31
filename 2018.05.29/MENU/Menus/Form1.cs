using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menus
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void teste1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmTeste1 tst1 = new frmTeste1(); //criando uma instância do formulário teste1
            tst1.MdiParent = this;            //esta linha define que a instância do forumlário criado é "filho" do formulário principal
            tst1.Show();                      //esta linha exibe o formulário teste1

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblData.Text = "Data: " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void teste2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeste2 tst2 = new frmTeste2(); //criando uma instância do formulário teste1
            tst2.MdiParent = this;            //esta linha define que a instância do forumlário criado é "filho" do formulário principal
            tst2.Show();                      //esta linha exibe o formulário teste2
        }

    }
}
