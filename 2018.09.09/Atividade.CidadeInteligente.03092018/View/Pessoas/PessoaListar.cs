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
    public partial class PessoaListar : Form
    {

        private int idPessoa = 0;

        public PessoaListar()
        {
            InitializeComponent();
        }

        private void retornarPessoas()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=LAB-06-05";
            conexao.Open();

            string comandoSQL = "SELECT * FROM tb_pessoa";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvPessoas.DataSource = dt;

            conexao.Close();

            txbNome.Text = dgvPessoas.Rows[0].Cells[1].Value.ToString();
            txbEndereco.Text = dgvPessoas.Rows[0].Cells[2].Value.ToString();
            txbEstadoCivil.Text = dgvPessoas.Rows[0].Cells[3].Value.ToString();
            dtNascimento.Text = dgvPessoas.Rows[0].Cells[4].Value.ToString();
            idPessoa = Convert.ToInt16(dgvPessoas.Rows[0].Cells[0].Value.ToString());
        }

        private void dgvPessoas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txbNome.Text = dgvPessoas.Rows[e.RowIndex].Cells[1].Value.ToString();
            txbEndereco.Text = dgvPessoas.Rows[e.RowIndex].Cells[2].Value.ToString();
            txbEstadoCivil.Text = dgvPessoas.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtNascimento.Text = dgvPessoas.Rows[e.RowIndex].Cells[4].Value.ToString();
            idPessoa = Convert.ToInt16( dgvPessoas.Rows[e.RowIndex].Cells[0].Value.ToString() );
        }

        private void Pessoa_Load(object sender, EventArgs e)
        {
            retornarPessoas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=LAB-06-05";
            conexao.Open();

            string comandoSQL = string.Concat("UPDATE tb_pessoa SET nmPessoa = '" + txbNome.Text + "', dsEndereco = '" + txbEndereco.Text + "', dsEstadoCivil = '" + txbEstadoCivil.Text + "', dtDataNascimento = '" + dtNascimento.Text + "' WHERE idPessoa = " + idPessoa);

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            sqlCommand.ExecuteNonQuery();

            conexao.Close();

            MessageBox.Show("Alterado com sucesso.");
            retornarPessoas();
        }
    }
}
