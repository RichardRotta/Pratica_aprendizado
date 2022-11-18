using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Rico
{
    public partial class frmLogin : Form
    {
        frmConsultaDados frmCons = new frmConsultaDados();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btAcessar_Click(object sender, EventArgs e)
        {
            // Variaveis de acesso hardcode
            String user = "Admin", password = "Admin";
            // Permissão de acesso para a consulta de dados
            if (txtUser.Text != user || txtPassword.Text != password)
            {
                MessageBox.Show("Acesso Negado!", "Controle de Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.Hide(); // Ocutar esse formulário
                txtUser.Clear(); // Limpar a caixa de texto user
                txtPassword.Clear(); // Limpar a caixa de texto password
                frmCons.ShowDialog(); // Exibir o frmConsultaDados
            }
        }
    }
}
