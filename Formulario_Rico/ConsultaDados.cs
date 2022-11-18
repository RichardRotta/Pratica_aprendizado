using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Formulario_Rico
{
    public partial class frmConsultaDados : Form
    {
        public frmConsultaDados()
        {
            InitializeComponent();
        }

        private void btSair2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaDados_Load(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=cadastro_rico; password=''"); // Conexão com o DB
            MySqlCommand sqlQuery = new MySqlCommand("SELECT * FROM cadastro", conexao); // Comando SQL

            try
            {
                conexao.Open(); // Abrir conexão
                MySqlDataReader dateReader = sqlQuery.ExecuteReader(); // Executar a leitura comando SQL

                while (dateReader.Read())
                {
                    object[] registro = new object[dateReader.FieldCount];

                    // Cabeçalho para o Data Grid
                    if (dgvConsultaDados.Rows.Count == 0)
                    {
                        for (int i = 0; i < dateReader.FieldCount; i++)
                        {
                            dgvConsultaDados.Columns.Add(dateReader.GetName(i), dateReader.GetName(i));
                        }
                    }

                    // Tras o registro
                    for (int i = 0; i < dateReader.FieldCount; i++)
                    {
                        registro[i] = dateReader.GetValue(i); // Monta o registro
                    }
                    dgvConsultaDados.Rows.Add(registro); // Add a linha
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex, "Erro, atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mostrar erro
            }
            finally
            {
                conexao.Close(); // Fechar conexão
            }
        }

        private void btAtuaizar_Click(object sender, EventArgs e)
        {
            dgvConsultaDados.Rows.Clear();
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=cadastro_rico; password=''"); // Conexão com o DB
            MySqlCommand sqlQuery = new MySqlCommand("SELECT * FROM cadastro", conexao); // Comando SQL

            try
            {
                conexao.Open(); // Abrir conexão
                MySqlDataReader dateReader = sqlQuery.ExecuteReader(); // Executar a leitura comando SQL

                while (dateReader.Read())
                {
                    object[] registro = new object[dateReader.FieldCount];

                    // Cabeçalho para o Data Grid
                    if (dgvConsultaDados.Rows.Count == 0)
                    {
                        for (int i = 0; i < dateReader.FieldCount; i++)
                        {
                            dgvConsultaDados.Columns.Add(dateReader.GetName(i), dateReader.GetName(i));
                        }
                    }

                    // Tras o registro
                    for (int i = 0; i < dateReader.FieldCount; i++)
                    {
                        registro[i] = dateReader.GetValue(i); // Monta o registro
                    }
                    dgvConsultaDados.Rows.Add(registro); // Add a linha
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex, "Erro, atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mostrar erro
            }
            finally
            {
                conexao.Close(); // Fechar conexão
            }
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            var resp = MessageBox.Show("Tem certeza que deseja deletar esses dados?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resp == DialogResult.Yes)
            {
                // Salavando os dados no Database
                MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=cadastro_rico; password=''"); // Conexão com o servidor
                MySqlCommand sqlQuery = new MySqlCommand("DELETE FROM cadastro WHERE CPF=" + txtCpfConsulta.Text, conexao); // Comando SQL
                try
                {
                    // Abrir conexão
                    conexao.Open();
                    // Executando o comando do sqlQuery
                    sqlQuery.ExecuteNonQuery();
                    MessageBox.Show("Dados deletados com sucesso!", "Deletar Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    // Mensagem caso de erro no banco de dados
                    MessageBox.Show("Erro:" + ex, "Erro Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    conexao.Close(); // Fechar conexão
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
