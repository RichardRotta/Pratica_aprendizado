using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Formulario_XPI
{
    public partial class Form1 : Form
    {
        // Atributo
        Dados dds = new Dados(); //Instancia do objeto
        public Form1()
        {
            InitializeComponent();
            //Caracterizando o label17 como um tipo datatime
            label17.Text = DateTime.Now.ToShortDateString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            // Selecionar todo o texto da caixa ao clicar
            textBox5.SelectAll();
            textBox7.SelectAll();
            textBox8.SelectAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Fechar a aplicação ao clicar no botão
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //criando váriavel para armazenar dados do tipo txt
            string cpf_valido = textBox4.Text;
            string cel_valido = textBox6.Text;
            string limit_dia = textBox5.Text;
            string limit_mes = textBox7.Text;
            string limit_ano = textBox8.Text;

            //condição para bloquear e desbloquear o button2
            if (!(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || cpf_valido.Length != 11 || cel_valido.Length != 11 || textBox2.Text != textBox3.Text || radioButton1.Checked == false && radioButton2.Checked == false || checkBox1.Checked == false && checkBox2.Checked == false || limit_dia.Length != 2 || limit_mes.Length != 2 || limit_ano.Length != 4))
            {
                //Destravando o button2 para clicar
                button2.Enabled = true;
            }
            else
            {
                //Travando o button2 para clicar
                button2.Enabled = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //criando váriavel para armazenar dados do tipo txt
            string cpf_valido = textBox4.Text;
            string cel_valido = textBox6.Text;
            string limit_dia = textBox5.Text;
            string limit_mes = textBox7.Text;
            string limit_ano = textBox8.Text;
            

            //Condição para salvar os dados
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || cpf_valido.Length != 11 || cel_valido.Length != 11)
            {
                MessageBox.Show("Dados Incompletos", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("Email inválido", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (radioButton1.Checked == false && radioButton2.Checked == false || checkBox1.Checked == false && checkBox2.Checked == false)
                    {
                        MessageBox.Show("Dados incompleto", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (limit_dia.Length != 2 || limit_mes.Length != 2 || limit_ano.Length != 4)
                        {
                            MessageBox.Show("Data inválida", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            //Setando os dados da caixa de texto
                            dds.setNome(textBox1.Text);
                            dds.setEmail(textBox2.Text);
                            dds.setConf_Email(textBox3.Text);
                            dds.setCPF(textBox4.Text);
                            dds.setCelular(textBox6.Text);
                            dds.setdia(textBox5.Text);
                            dds.setmes(textBox7.Text);
                            dds.setano(textBox8.Text);
                            MessageBox.Show("Dados salvos com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //criando variável e setando os componentes
            string txt_proc, txt_receb1, txt_receb2, data_hoje;
            //setando para que só um botão seja validado
            txt_proc = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
            txt_receb1 = checkBox1.Text;
            txt_receb2 = checkBox2.Text;
            data_hoje = label17.Text;
            string dia = dds.getdia();
            string mes = dds.getmes();
            string ano = dds.getano();
            string format_dt = dia + "/" + mes + "/" + ano;

            //Condição para caso seja selecionado um componente ou mais
                if (checkBox1.Checked == true && checkBox2.Checked == true)
                {
                    string vMessage = "Nome.....................: " + dds.getNome() +
                                      "\nEmail..................: " + dds.getEmail() +
                                      "\nConfirmação Email: " + dds.getConf_Email() +
                                      "\nCPF....................: " + dds.getCPF() +
                                      "\nData...................: " + format_dt +
                                      "\nCelular................: " + dds.getCelular() +
                                      "\n\nPROCURADOR?: " +
                                      "\n" + txt_proc +
                                      "\n\nRECEBIMENTO DE INFORMAÇÕES:" +
                                      "\n" + txt_receb1 + " E " + txt_receb2;
                    MessageBox.Show(vMessage, "Dados do Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            else
            {
                if (checkBox2.Checked == true)
                {
                    string vMessage = "Nome.....................: " + dds.getNome() +
                                      "\nEmail..................: " + dds.getEmail() +
                                      "\nConfirmação Email: " + dds.getConf_Email() +
                                      "\nCPF....................: " + dds.getCPF() +
                                      "\nData...................: " + format_dt +
                                      "\nCelular................: " + dds.getCelular() +
                                      "\n\nPROCURADOR?: " +
                                      "\n" + txt_proc +
                                      "\n\nRECEBIMENTO DE INFORMAÇÕES:" +
                                      "\n" + txt_receb2;
                    MessageBox.Show(vMessage, "Dados do Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (checkBox1.Checked)
                    {
                        string vMessage = "Nome.....................: " + dds.getNome() +
                                      "\nEmail..................: " + dds.getEmail() +
                                      "\nConfirmação Email: " + dds.getConf_Email() +
                                      "\nCPF....................: " + dds.getCPF() +
                                      "\nData...................: " + format_dt +
                                      "\nCelular................: " + dds.getCelular() +
                                      "\n\nPROCURADOR?: " +
                                      "\n" + txt_proc +
                                      "\n\nRECEBIMENTO DE INFORMAÇÕES:" +
                                      "\n" + txt_receb1;
                        MessageBox.Show(vMessage, "Dados do Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
