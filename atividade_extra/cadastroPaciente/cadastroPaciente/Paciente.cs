using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cadastroPaciente
{
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
        }

        private void Paciente_Load(object sender, EventArgs e)
        {
            retornarPacientes();
        }

        private void retornarPacientes()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=atvextra;Data Source=LAB-06-12";
            conexao.Open();

            string comandoSQL = "SELECT * FROM paciente";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvPaciente.DataSource = dt;

            conexao.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbEmail.Text = "";
            txbEndereco.Text = "";
            txbNome.Text = "";
            txbTelefone.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=atvextra;Data Source=LAB-06-12";
            conexao.Open();

            string comandoSQL = string.Concat("insert into paciente (nome, endereco, fone, email) values ('" + txbNome.Text + "', '" + txbEndereco.Text + "', '" + txbTelefone.Text + "', '" + txbEmail.Text + "')");

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            sqlCommand.ExecuteNonQuery();

            conexao.Close();

            MessageBox.Show("Cadastrado com sucesso.");

            retornarPacientes();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=atvextra;Data Source=LAB-06-12";
            conexao.Open();

            string comandoSQL = "SELECT * FROM paciente where nome like '%" + txbPesquisa.Text + "%' or endereco '%" + txbPesquisa.Text + "%'";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvPaciente.DataSource = dt;

            conexao.Close();
        }
    }
}
