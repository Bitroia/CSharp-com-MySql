using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System.Configuration;
using System.Drawing.Text;
using System.Windows.Forms;

namespace conectarbanco
{
    public partial class Form1 : Form
    {
        string strConexao = "server=localhost;User Id=root;database=teste; password=0102548";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(strConexao);
                conexao.Open();
                MessageBox.Show("Conexao realizada com sucesso");
                conexao.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }
        }

        private void btncadastra_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text;
            string tel = txttelefone.Text;

            if (nome == "")
            {
                MessageBox.Show("Preencha o campo Nome!");
                txtnome.Focus();
                return;
            }


            if (!txttelefone.MaskCompleted)
            {
                // O MaskedTextBox está vazio ou incompleto
                MessageBox.Show("Preencha o campo Telefone!");
                txttelefone.Focus();
                return;
            }
            else
            {
                // O MaskedTextBox está completo
                tel = txttelefone.Text;
            }

           
            MySqlConnection conexao = new MySqlConnection(strConexao);
            conexao.Open();

            MySqlCommand comm = conexao.CreateCommand();
            comm.CommandText = "INSERT INTO cadastro(nome,telefone) VALUES(@nome, @telefone)";
            comm.Parameters.AddWithValue("@nome", nome);
            comm.Parameters.AddWithValue("@telefone", tel);

            if (comm.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("O comando INSERT foi executado com sucesso!");
                txtnome.Clear();
                txttelefone.Clear();
                txtnome.Focus();
            }
            else
            {
                MessageBox.Show("O comando INSERT foi executado, mas nenhum registro foi afetado.");
            }

            conexao.Close();

        }
    }
}

