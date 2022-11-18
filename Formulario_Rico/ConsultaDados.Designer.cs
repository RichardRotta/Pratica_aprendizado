namespace Formulario_Rico
{
    partial class frmConsultaDados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaDados));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvConsultaDados = new System.Windows.Forms.DataGridView();
            this.btSair2 = new System.Windows.Forms.Button();
            this.btExibir = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.txtCpfConsulta = new System.Windows.Forms.TextBox();
            this.lbCpfConsulta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDados)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Formulario_Rico.Properties.Resources.banner_rico;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 65);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvConsultaDados
            // 
            this.dgvConsultaDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaDados.Location = new System.Drawing.Point(40, 119);
            this.dgvConsultaDados.Name = "dgvConsultaDados";
            this.dgvConsultaDados.Size = new System.Drawing.Size(694, 236);
            this.dgvConsultaDados.TabIndex = 1;
            // 
            // btSair2
            // 
            this.btSair2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btSair2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSair2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btSair2.FlatAppearance.BorderSize = 0;
            this.btSair2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btSair2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair2.ForeColor = System.Drawing.Color.White;
            this.btSair2.Location = new System.Drawing.Point(684, 396);
            this.btSair2.Name = "btSair2";
            this.btSair2.Size = new System.Drawing.Size(73, 30);
            this.btSair2.TabIndex = 56;
            this.btSair2.Text = "Sair";
            this.btSair2.UseVisualStyleBackColor = false;
            this.btSair2.Click += new System.EventHandler(this.btSair2_Click);
            // 
            // btExibir
            // 
            this.btExibir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btExibir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExibir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btExibir.FlatAppearance.BorderSize = 0;
            this.btExibir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btExibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExibir.ForeColor = System.Drawing.Color.White;
            this.btExibir.Location = new System.Drawing.Point(553, 396);
            this.btExibir.Name = "btExibir";
            this.btExibir.Size = new System.Drawing.Size(125, 30);
            this.btExibir.TabIndex = 57;
            this.btExibir.Text = "Exibir dados";
            this.btExibir.UseVisualStyleBackColor = false;
            this.btExibir.Click += new System.EventHandler(this.btAtuaizar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDeletar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btDeletar.FlatAppearance.BorderSize = 0;
            this.btDeletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletar.ForeColor = System.Drawing.Color.White;
            this.btDeletar.Location = new System.Drawing.Point(193, 396);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(82, 30);
            this.btDeletar.TabIndex = 58;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = false;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // txtCpfConsulta
            // 
            this.txtCpfConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfConsulta.Location = new System.Drawing.Point(39, 398);
            this.txtCpfConsulta.Name = "txtCpfConsulta";
            this.txtCpfConsulta.Size = new System.Drawing.Size(148, 26);
            this.txtCpfConsulta.TabIndex = 59;
            this.txtCpfConsulta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbCpfConsulta
            // 
            this.lbCpfConsulta.AutoSize = true;
            this.lbCpfConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbCpfConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(65)))));
            this.lbCpfConsulta.Location = new System.Drawing.Point(36, 375);
            this.lbCpfConsulta.Name = "lbCpfConsulta";
            this.lbCpfConsulta.Size = new System.Drawing.Size(107, 20);
            this.lbCpfConsulta.TabIndex = 60;
            this.lbCpfConsulta.Text = "Insira o CPF:";
            // 
            // frmConsultaDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 441);
            this.Controls.Add(this.lbCpfConsulta);
            this.Controls.Add(this.txtCpfConsulta);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btExibir);
            this.Controls.Add(this.btSair2);
            this.Controls.Add(this.dgvConsultaDados);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Dados (Admin)";
            this.Load += new System.EventHandler(this.frmConsultaDados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvConsultaDados;
        private System.Windows.Forms.Button btSair2;
        private System.Windows.Forms.Button btExibir;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.TextBox txtCpfConsulta;
        private System.Windows.Forms.Label lbCpfConsulta;
    }
}