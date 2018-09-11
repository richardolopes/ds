using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace View.Documentos
{
    public partial class DocumentoListar : Form
    {
        public DocumentoListar()
        {
            InitializeComponent();
        }

        private void retornarDocumentos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=LAB-06-17";
            conexao.Open();

            string comandoSQL = "SELECT * FROM tb_pessoaDocumento";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvDocumentos.DataSource = dt;

            conexao.Close();
        }

        private void DocumentoListar_Load(object sender, EventArgs e)
        {
            retornarDocumentos();
        }
    }
}
