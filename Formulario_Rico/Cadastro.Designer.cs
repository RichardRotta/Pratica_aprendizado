namespace Formulario_Rico
{
    partial class frmCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.lbCelular = new System.Windows.Forms.Label();
            this.lbDataNasc = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbConfirmEmail = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.lbDescricao1 = new System.Windows.Forms.Label();
            this.cbWhatsapp = new System.Windows.Forms.CheckBox();
            this.cbEmailSms = new System.Windows.Forms.CheckBox();
            this.lbCampoCelular = new System.Windows.Forms.Label();
            this.lbCampoCpf = new System.Windows.Forms.Label();
            this.lbCampoConfirmEmail = new System.Windows.Forms.Label();
            this.lbCampoEmail = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtConfirmEmail = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbCampoNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.lbCampoDataNasc = new System.Windows.Forms.Label();
            this.btConsultaDados = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(65)))));
            this.lbCelular.Location = new System.Drawing.Point(449, 496);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(67, 20);
            this.lbCelular.TabIndex = 61;
            this.lbCelular.Text = "Celular:";
            // 
            // lbDataNasc
            // 
            this.lbDataNasc.AutoSize = true;
            this.lbDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbDataNasc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(65)))));
            this.lbDataNasc.Location = new System.Drawing.Point(62, 496);
            this.lbDataNasc.Name = "lbDataNasc";
            this.lbDataNasc.Size = new System.Drawing.Size(167, 20);
            this.lbDataNasc.TabIndex = 60;
            this.lbDataNasc.Text = "Data de Nascimento:";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(65)))));
            this.lbCpf.Location = new System.Drawing.Point(62, 424);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(47, 20);
            this.lbCpf.TabIndex = 59;
            this.lbCpf.Text = "CPF:";
            // 
            // lbConfirmEmail
            // 
            this.lbConfirmEmail.AutoSize = true;
            this.lbConfirmEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbConfirmEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(65)))));
            this.lbConfirmEmail.Location = new System.Drawing.Point(61, 341);
            this.lbConfirmEmail.Name = "lbConfirmEmail";
            this.lbConfirmEmail.Size = new System.Drawing.Size(141, 20);
            this.lbConfirmEmail.TabIndex = 58;
            this.lbConfirmEmail.Text = "Confirmar E-mail:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(65)))));
            this.lbEmail.Location = new System.Drawing.Point(61, 261);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(62, 20);
            this.lbEmail.TabIndex = 57;
            this.lbEmail.Text = "E-mail:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(65)))));
            this.lbNome.Location = new System.Drawing.Point(62, 185);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(58, 20);
            this.lbNome.TabIndex = 56;
            this.lbNome.Text = "Nome:";
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.Color.White;
            this.btSair.Location = new System.Drawing.Point(787, 622);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(73, 30);
            this.btSair.TabIndex = 55;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btSalvar.ForeColor = System.Drawing.Color.White;
            this.btSalvar.Location = new System.Drawing.Point(707, 622);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(73, 30);
            this.btSalvar.TabIndex = 53;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // lbDescricao1
            // 
            this.lbDescricao1.AutoSize = true;
            this.lbDescricao1.Font = new System.Drawing.Font("Futura Md BT", 12.5F, System.Drawing.FontStyle.Bold);
            this.lbDescricao1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(68)))));
            this.lbDescricao1.Location = new System.Drawing.Point(61, 570);
            this.lbDescricao1.Name = "lbDescricao1";
            this.lbDescricao1.Size = new System.Drawing.Size(598, 40);
            this.lbDescricao1.TabIndex = 51;
            this.lbDescricao1.Text = "Como deseja receber informações sobre serviços e produtos \r\noferecidos, além de s" +
    "aber sobre as vantagens de ser um cliente Rico?";
            // 
            // cbWhatsapp
            // 
            this.cbWhatsapp.AutoSize = true;
            this.cbWhatsapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbWhatsapp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(65)))));
            this.cbWhatsapp.Location = new System.Drawing.Point(203, 618);
            this.cbWhatsapp.Name = "cbWhatsapp";
            this.cbWhatsapp.Size = new System.Drawing.Size(105, 24);
            this.cbWhatsapp.TabIndex = 49;
            this.cbWhatsapp.Text = "WhatsApp";
            this.cbWhatsapp.UseVisualStyleBackColor = true;
            // 
            // cbEmailSms
            // 
            this.cbEmailSms.AutoSize = true;
            this.cbEmailSms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbEmailSms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(65)))));
            this.cbEmailSms.Location = new System.Drawing.Point(66, 618);
            this.cbEmailSms.Name = "cbEmailSms";
            this.cbEmailSms.Size = new System.Drawing.Size(131, 24);
            this.cbEmailSms.TabIndex = 48;
            this.cbEmailSms.Text = "E-mail e SMS";
            this.cbEmailSms.UseVisualStyleBackColor = true;
            // 
            // lbCampoCelular
            // 
            this.lbCampoCelular.AutoSize = true;
            this.lbCampoCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbCampoCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(65)))));
            this.lbCampoCelular.Location = new System.Drawing.Point(450, 549);
            this.lbCampoCelular.Name = "lbCampoCelular";
            this.lbCampoCelular.Size = new System.Drawing.Size(92, 13);
            this.lbCampoCelular.TabIndex = 46;
            this.lbCampoCelular.Text = "Campo obrigatório";
            // 
            // lbCampoCpf
            // 
            this.lbCampoCpf.AutoSize = true;
            this.lbCampoCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbCampoCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(65)))));
            this.lbCampoCpf.Location = new System.Drawing.Point(62, 475);
            this.lbCampoCpf.Name = "lbCampoCpf";
            this.lbCampoCpf.Size = new System.Drawing.Size(92, 13);
            this.lbCampoCpf.TabIndex = 45;
            this.lbCampoCpf.Text = "Campo obrigatório";
            // 
            // lbCampoConfirmEmail
            // 
            this.lbCampoConfirmEmail.AutoSize = true;
            this.lbCampoConfirmEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbCampoConfirmEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(65)))));
            this.lbCampoConfirmEmail.Location = new System.Drawing.Point(62, 392);
            this.lbCampoConfirmEmail.Name = "lbCampoConfirmEmail";
            this.lbCampoConfirmEmail.Size = new System.Drawing.Size(92, 13);
            this.lbCampoConfirmEmail.TabIndex = 44;
            this.lbCampoConfirmEmail.Text = "Campo obrigatório";
            // 
            // lbCampoEmail
            // 
            this.lbCampoEmail.AutoSize = true;
            this.lbCampoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbCampoEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(65)))));
            this.lbCampoEmail.Location = new System.Drawing.Point(62, 313);
            this.lbCampoEmail.Name = "lbCampoEmail";
            this.lbCampoEmail.Size = new System.Drawing.Size(92, 13);
            this.lbCampoEmail.TabIndex = 41;
            this.lbCampoEmail.Text = "Campo obrigatório";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(107)))), ((int)(((byte)(132)))));
            this.txtCelular.Location = new System.Drawing.Point(452, 519);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(374, 26);
            this.txtCelular.TabIndex = 43;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(107)))), ((int)(((byte)(132)))));
            this.txtCpf.Location = new System.Drawing.Point(65, 445);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(761, 26);
            this.txtCpf.TabIndex = 38;
            // 
            // txtConfirmEmail
            // 
            this.txtConfirmEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtConfirmEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(107)))), ((int)(((byte)(132)))));
            this.txtConfirmEmail.Location = new System.Drawing.Point(65, 362);
            this.txtConfirmEmail.Name = "txtConfirmEmail";
            this.txtConfirmEmail.Size = new System.Drawing.Size(761, 26);
            this.txtConfirmEmail.TabIndex = 37;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(107)))), ((int)(((byte)(132)))));
            this.txtEmail.Location = new System.Drawing.Point(65, 282);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(761, 26);
            this.txtEmail.TabIndex = 36;
            // 
            // lbCampoNome
            // 
            this.lbCampoNome.AutoSize = true;
            this.lbCampoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbCampoNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(65)))));
            this.lbCampoNome.Location = new System.Drawing.Point(62, 237);
            this.lbCampoNome.Name = "lbCampoNome";
            this.lbCampoNome.Size = new System.Drawing.Size(92, 13);
            this.lbCampoNome.TabIndex = 35;
            this.lbCampoNome.Text = "Campo obrigatório";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(107)))), ((int)(((byte)(132)))));
            this.txtNome.Location = new System.Drawing.Point(65, 206);
            this.txtNome.Margin = new System.Windows.Forms.Padding(6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(761, 26);
            this.txtNome.TabIndex = 34;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Futura Md BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.lbTitulo.Location = new System.Drawing.Point(60, 87);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(276, 29);
            this.lbTitulo.TabIndex = 33;
            this.lbTitulo.Text = "Olá, Seja Bem-Vindo!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(63, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 40);
            this.label1.TabIndex = 63;
            this.label1.Text = "Para abrir uma conta grátis e começar a investir com segurança, \r\nprecisamos sabe" +
    "r mais sobre você. Vamos começar?";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(107)))), ((int)(((byte)(132)))));
            this.dtpDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(65, 519);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(380, 26);
            this.dtpDataNasc.TabIndex = 64;
            // 
            // lbCampoDataNasc
            // 
            this.lbCampoDataNasc.AutoSize = true;
            this.lbCampoDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbCampoDataNasc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(65)))));
            this.lbCampoDataNasc.Location = new System.Drawing.Point(62, 549);
            this.lbCampoDataNasc.Name = "lbCampoDataNasc";
            this.lbCampoDataNasc.Size = new System.Drawing.Size(92, 13);
            this.lbCampoDataNasc.TabIndex = 65;
            this.lbCampoDataNasc.Text = "Campo obrigatório";
            // 
            // btConsultaDados
            // 
            this.btConsultaDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btConsultaDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConsultaDados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btConsultaDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultaDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btConsultaDados.ForeColor = System.Drawing.Color.White;
            this.btConsultaDados.Location = new System.Drawing.Point(751, 66);
            this.btConsultaDados.Name = "btConsultaDados";
            this.btConsultaDados.Size = new System.Drawing.Size(158, 29);
            this.btConsultaDados.TabIndex = 66;
            this.btConsultaDados.Text = "Consultar Dados ";
            this.btConsultaDados.UseVisualStyleBackColor = false;
            this.btConsultaDados.Click += new System.EventHandler(this.btConsultaDados_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Formulario_Rico.Properties.Resources.banner_rico;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(921, 60);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 681);
            this.Controls.Add(this.btConsultaDados);
            this.Controls.Add(this.lbCampoDataNasc);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbCelular);
            this.Controls.Add(this.lbDataNasc);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.lbConfirmEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.lbDescricao1);
            this.Controls.Add(this.cbWhatsapp);
            this.Controls.Add(this.cbEmailSms);
            this.Controls.Add(this.lbCampoCelular);
            this.Controls.Add(this.lbCampoCpf);
            this.Controls.Add(this.lbCampoConfirmEmail);
            this.Controls.Add(this.lbCampoEmail);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtConfirmEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbCampoNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Rico";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.Label lbDataNasc;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbConfirmEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label lbDescricao1;
        private System.Windows.Forms.CheckBox cbWhatsapp;
        private System.Windows.Forms.CheckBox cbEmailSms;
        private System.Windows.Forms.Label lbCampoCelular;
        private System.Windows.Forms.Label lbCampoCpf;
        private System.Windows.Forms.Label lbCampoConfirmEmail;
        private System.Windows.Forms.Label lbCampoEmail;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtConfirmEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbCampoNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.Label lbCampoDataNasc;
        private System.Windows.Forms.Button btConsultaDados;
    }
}

