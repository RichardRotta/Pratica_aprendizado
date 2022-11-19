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
    // Nome: Richard Rotta  
    // Data: 17/11/2022
    // Projeto: Criando um formulário de cadastro e consulta de dados

    public partial class frmCadastro : Form
    {
        // Instância do Objeto
        frmLogin frmLog = new frmLogin();
        Dados dds = new Dados();
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btConsultaDados_Click(object sender, EventArgs e)
        {
            // Ao clicar no botão, exibir o formulário de login (frmLogin)
            frmLog.ShowDialog();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            // Variaveis para aplicar o .Length
            String cpf, celular;
            cpf = txtCpf.Text;
            celular = txtCelular.Text;

            // Condições para poder salvar os dados
            if (txtNome.Text == "" && txtEmail.Text == "" && txtConfirmEmail.Text == "" && cpf.Length != 11 && celular.Length != 11)
            {
                // Mensagem para caso a condição seje verdadeira
                MessageBox.Show("Dados Incompletos", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtNome.Text == "")
                {
                    // Mensagem para caso a condição seje verdadeira
                    MessageBox.Show("Insira um nome!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtEmail.Text == "")
                    {
                        // Mensagem para caso a condição seje verdadeira
                        MessageBox.Show("Insira um e-mail!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txtConfirmEmail.Text == "")
                        {
                            // Mensagem para caso a condição seje verdadeira
                            MessageBox.Show("Confirme seu email!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (txtEmail.Text != txtConfirmEmail.Text)
                            {
                                // Mensagem para caso a condição seje verdadeira
                                MessageBox.Show("E-mail Inválido!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (cpf == "")
                                {
                                    // Mensagem para caso a condição seje verdadeira
                                    MessageBox.Show("Insira um CPF!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    if (celular == "")
                                    {
                                        // Mensagem para caso a condição seje verdadeira
                                        MessageBox.Show("Insira um celular!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        if (cpf.Length != 11 || celular.Length != 11)
                                        {
                                            // Mensagem para caso a condição seje verdadeira
                                            MessageBox.Show("CPF e Celular Inválidos!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {

                                            if (!(cbEmailSms.Checked || cbWhatsapp.Checked))
                                            {
                                                // Mensagem para caso a condição seje verdadeira
                                                MessageBox.Show("Insira um método para o recebimento de informações!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                if (cbEmailSms.Checked == true && cbWhatsapp.Checked == false)
                                                {
                                                    // Criando variavel para pegar o texto do cbEmailSms
                                                    String emailSms;
                                                    emailSms = "E-mail e SMS";
                                                    // Salvamento de dados no método set
                                                    dds.setNome(txtNome.Text);
                                                    dds.setEmail(txtEmail.Text);
                                                    dds.setCpf(txtCpf.Text);
                                                    dds.setDataNasc(dtpDataNasc.Value);
                                                    dds.setCelular(txtCelular.Text);
                                                    dds.setRecebeInfo(emailSms);
                                                    txtNome.Clear();
                                                    txtEmail.Clear();
                                                    txtConfirmEmail.Clear();
                                                    txtCpf.Clear();
                                                    txtCelular.Clear();                                                 

                                                    // Salavando os dados no Database
                                                    MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=cadastro_rico; password=''"); // Conexão com o servidor
                                                    MySqlCommand sqlQuery = new MySqlCommand("INSERT INTO cadastro(cpf, nome, email, data_nasc, celular, receb_info)" + "VALUES(" + dds.getCpf() + ", '" + dds.getNome() + "', '" + dds.getEmail() + "', '" + dds.getDataNasc().ToString("yyyy/MM/dd") + "', '" + dds.getCelular() + "', '" + dds.getRecebeInfo() + "')", conexao); // Comando SQL
                                                    try
                                                    {
                                                        // Abrindo conexão com o servidor
                                                        conexao.Open();
                                                        // Executar a leitura comando SQL
                                                        sqlQuery.ExecuteNonQuery();
                                                        MessageBox.Show("Dados salvos com sucesso! [DB]", "Salvar Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        // Mensagem caso de erro no banco de dados
                                                        MessageBox.Show("Erro:" + ex, "Erro Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    }
                                                    finally
                                                    {
                                                        // Fechando conexão
                                                        conexao.Close();
                                                    }
                                                }
                                                else
                                                {
                                                    if (cbWhatsapp.Checked == true && cbEmailSms.Checked == false)
                                                    {
                                                        // Criando variavel para pegar o texto do cbWhatsapp
                                                        String whatsapp;
                                                        whatsapp = "Whatsapp";
                                                        // Salvamento de dados no método set
                                                        dds.setNome(txtNome.Text);
                                                        dds.setEmail(txtEmail.Text);
                                                        dds.setCpf(txtCpf.Text);
                                                        dds.setDataNasc(dtpDataNasc.Value);
                                                        dds.setCelular(txtCelular.Text);
                                                        dds.setRecebeInfo(whatsapp);
                                                        txtNome.Clear();
                                                        txtEmail.Clear();
                                                        txtConfirmEmail.Clear();
                                                        txtCpf.Clear();
                                                        txtCelular.Clear();

                                                        // Salavando os dados no Database
                                                        MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=cadastro_rico; password=''"); // Ceonexão com o servidor
                                                        MySqlCommand sqlQuery = new MySqlCommand("INSERT INTO cadastro(cpf, nome, email, data_nasc, celular, receb_info)" + "VALUES(" + dds.getCpf() + ", '" + dds.getNome() + "', '" + dds.getEmail() + "', '" + dds.getDataNasc().ToString("yyyy/MM/dd") + "', '" + dds.getCelular() + "', '" + dds.getRecebeInfo() + "')", conexao); // Comando SQL
                                                        try
                                                        {
                                                            // Abrindo conexão com o servidor
                                                            conexao.Open();
                                                            // Executar a leitura comando SQL
                                                            sqlQuery.ExecuteNonQuery();
                                                            MessageBox.Show("Dados salvos com sucesso! [DB]", "Salvar Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                        }
                                                        catch (Exception ex)
                                                        {
                                                            // Mensagem caso de erro no banco de dados
                                                            MessageBox.Show("Erro:" + ex, "Erro Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        }
                                                        finally
                                                        {
                                                            // Fechando conexão
                                                            conexao.Close();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        // Criando variavel para pegar o texto do cbEmailSms e cbWhatsapp
                                                        String duasInfos;
                                                        duasInfos = "E-mail, SMS e Whatsapp";
                                                        // Salvamento de dados no método set
                                                        dds.setNome(txtNome.Text);
                                                        dds.setEmail(txtEmail.Text);
                                                        dds.setCpf(txtCpf.Text);
                                                        dds.setDataNasc(dtpDataNasc.Value);
                                                        dds.setCelular(txtCelular.Text);
                                                        dds.setRecebeInfo(duasInfos);
                                                        txtNome.Clear();
                                                        txtEmail.Clear();
                                                        txtConfirmEmail.Clear();
                                                        txtCpf.Clear();
                                                        txtCelular.Clear();

                                                        // Salvando os dados no Database
                                                        MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=cadastro_rico; password=''"); // Conectando com o servidor
                                                        MySqlCommand sqlQuery = new MySqlCommand("INSERT INTO cadastro(cpf, nome, email, data_nasc, celular, receb_info)" + "VALUES(" + dds.getCpf() + ", '" + dds.getNome() + "', '" + dds.getEmail() + "', '" + dds.getDataNasc().ToString("yyyy/MM/dd") + "', '" + dds.getCelular() + "', '" + dds.getRecebeInfo() + "')", conexao); // Comando SQL
                                                        try
                                                        {
                                                            // Abrindo conexão com o servidor
                                                            conexao.Open();
                                                            // Executar a leitura comando SQL
                                                            sqlQuery.ExecuteNonQuery();
                                                            MessageBox.Show("Dados salvos com sucesso! [DB]", "Salvar Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                        }
                                                        catch (Exception ex)
                                                        {
                                                            // Mensagem caso de erro no banco de dados
                                                            MessageBox.Show("Erro:" + ex, "Erro Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        }
                                                        finally
                                                        {
                                                            // Fechando conexão
                                                            conexao.Close();
                                                        }
                                                    }
                                                }
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            dtpDataNasc.Format = DateTimePickerFormat.Short;
        }
    }
}

