using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using View.Pessoas;
using View.Clientes;
using View.Documentos;
using View.Funcionarios;

namespace View
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        /* Pessoas */
        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pessoa tela = new Pessoa();
            tela.MdiParent = this;
            tela.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PessoaCadastrar tela = new PessoaCadastrar();
            tela.MdiParent = this;
            tela.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PessoaEditar tela = new PessoaEditar();
            tela.MdiParent = this;
            tela.Show();
        }

        /* Clientes */
        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClienteListar tela = new ClienteListar();
            tela.MdiParent = this;
            tela.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClienteCadastrar tela = new ClienteCadastrar();
            tela.MdiParent = this;
            tela.Show();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClienteEditar tela = new ClienteEditar();
            tela.MdiParent = this;
            tela.Show();
        }

        /* Funcionários */
        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FuncionarioListar tela = new FuncionarioListar();
            tela.MdiParent = this;
            tela.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FuncionarioCadastrar tela = new FuncionarioCadastrar();
            tela.MdiParent = this;
            tela.Show();
        }

        private void editarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FuncionarioEditar tela = new FuncionarioEditar();
            tela.MdiParent = this;
            tela.Show();
        }

        /* Documentos */
        private void listarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DocumentoListar tela = new DocumentoListar();
            tela.MdiParent = this;
            tela.Show();
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DocumentoCadastrar tela = new DocumentoCadastrar();
            tela.MdiParent = this;
            tela.Show();
        }

        private void editarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DocumentoEditar tela = new DocumentoEditar();
            tela.MdiParent = this;
            tela.Show();
        }
    }
}
