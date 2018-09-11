using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace View.Funcionarios
{
    public partial class FuncionarioListar : Form
    {
        public FuncionarioListar()
        {
            InitializeComponent();
        }

        private void retornarFuncionarios()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=LAB-06-17";
            conexao.Open();

            string comandoSQL = "SELECT * FROM tb_funcionario";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvFuncionarios.DataSource = dt;

            conexao.Close();
        }

        private void FuncionarioListar_Load(object sender, EventArgs e)
        {
            retornarFuncionarios();
        }
    }
}
