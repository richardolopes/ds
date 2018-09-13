using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace View.Pessoas
{
    public partial class PessoaCadastrar : Form
    {
        public PessoaCadastrar()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=LAB-06-05";
            conexao.Open();

            string comandoSQL = string.Concat("INSERT INTO tb_pessoa (nmPessoa, dsEndereco, dsEstadoCivil, dtDataNascimento) values ('" + txbNome.Text + "', '" + txbEndereco.Text + "', '" + txbEstadoCivil.Text + "', '" + dtNascimento.Text + "')");

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            sqlCommand.ExecuteNonQuery();

            conexao.Close();

            MessageBox.Show("Alterado com sucesso.");
            txbNome.Text = "";
            txbEndereco.Text = "";
            txbEstadoCivil.Text = "";
        }
    }
}
