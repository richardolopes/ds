using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace View.Clientes
{
    public partial class ClienteListar : Form
    {
        public ClienteListar()
        {
            InitializeComponent();
        }

        private void ClienteListar_Load(object sender, EventArgs e)
        {
            retornarClientes();
        }

        private void retornarClientes()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=LAB-06-17";
            conexao.Open();

            string comandoSQL = "SELECT idCliente 'Código Cliente', idPessoa 'Código Pessoa' FROM tb_cliente";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvClientes.DataSource = dt;

            conexao.Close();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show( dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString() ); 
        }
    }
}
