
namespace ConsultorioMedico
{
    partial class frmPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gpbMedico = new System.Windows.Forms.GroupBox();
            this.btnCarregaEndereco = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mkbCPF = new System.Windows.Forms.MaskedTextBox();
            this.mkbCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mkbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gpbMedico.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Location = new System.Drawing.Point(2, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 97);
            this.panel1.TabIndex = 1;
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(33, 29);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(96, 55);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(543, 29);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 55);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(645, 29);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(96, 55);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(441, 29);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(96, 55);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(339, 29);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(96, 55);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(237, 29);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(96, 55);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(135, 29);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(96, 55);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gpbMedico
            // 
            this.gpbMedico.Controls.Add(this.btnCarregaEndereco);
            this.gpbMedico.Controls.Add(this.txtCodigo);
            this.gpbMedico.Controls.Add(this.lblCPF);
            this.gpbMedico.Controls.Add(this.mkbCPF);
            this.gpbMedico.Controls.Add(this.mkbCEP);
            this.gpbMedico.Controls.Add(this.lblEstado);
            this.gpbMedico.Controls.Add(this.cbbEstado);
            this.gpbMedico.Controls.Add(this.lblCEP);
            this.gpbMedico.Controls.Add(this.txtCidade);
            this.gpbMedico.Controls.Add(this.lblCidade);
            this.gpbMedico.Controls.Add(this.txtBairro);
            this.gpbMedico.Controls.Add(this.lblBairro);
            this.gpbMedico.Controls.Add(this.txtEndereco);
            this.gpbMedico.Controls.Add(this.label1);
            this.gpbMedico.Controls.Add(this.mkbTelefone);
            this.gpbMedico.Controls.Add(this.lblCodigo);
            this.gpbMedico.Controls.Add(this.lblTelefone);
            this.gpbMedico.Controls.Add(this.lblNome);
            this.gpbMedico.Controls.Add(this.txtEmail);
            this.gpbMedico.Controls.Add(this.txtNome);
            this.gpbMedico.Controls.Add(this.lblEmail);
            this.gpbMedico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMedico.Location = new System.Drawing.Point(12, 17);
            this.gpbMedico.Name = "gpbMedico";
            this.gpbMedico.Size = new System.Drawing.Size(760, 442);
            this.gpbMedico.TabIndex = 2;
            this.gpbMedico.TabStop = false;
            this.gpbMedico.Text = "Informações do Paciente";
            // 
            // btnCarregaEndereco
            // 
            this.btnCarregaEndereco.Location = new System.Drawing.Point(512, 362);
            this.btnCarregaEndereco.Name = "btnCarregaEndereco";
            this.btnCarregaEndereco.Size = new System.Drawing.Size(183, 32);
            this.btnCarregaEndereco.TabIndex = 25;
            this.btnCarregaEndereco.Text = "Carrega Endereço";
            this.btnCarregaEndereco.UseVisualStyleBackColor = true;
            this.btnCarregaEndereco.Click += new System.EventHandler(this.btnCarregaEndereco_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(60, 82);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(99, 26);
            this.txtCodigo.TabIndex = 24;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(576, 124);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(41, 18);
            this.lblCPF.TabIndex = 23;
            this.lblCPF.Text = "CPF";
            // 
            // mkbCPF
            // 
            this.mkbCPF.Location = new System.Drawing.Point(579, 145);
            this.mkbCPF.Mask = "000,000,000-00";
            this.mkbCPF.Name = "mkbCPF";
            this.mkbCPF.Size = new System.Drawing.Size(117, 26);
            this.mkbCPF.TabIndex = 22;
            // 
            // mkbCEP
            // 
            this.mkbCEP.Location = new System.Drawing.Point(612, 212);
            this.mkbCEP.Mask = "00000-000";
            this.mkbCEP.Name = "mkbCEP";
            this.mkbCEP.Size = new System.Drawing.Size(84, 26);
            this.mkbCEP.TabIndex = 21;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(57, 339);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(58, 18);
            this.lblEstado.TabIndex = 20;
            this.lblEstado.Text = "Estado";
            // 
            // cbbEstado
            // 
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(59, 360);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(171, 26);
            this.cbbEstado.TabIndex = 19;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(609, 189);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(42, 18);
            this.lblCEP.TabIndex = 18;
            this.lblCEP.Text = "CEP";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(361, 283);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(334, 26);
            this.txtCidade.TabIndex = 15;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(358, 260);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(60, 18);
            this.lblCidade.TabIndex = 16;
            this.lblCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(59, 283);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(286, 26);
            this.txtBairro.TabIndex = 13;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(56, 260);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(51, 18);
            this.lblBairro.TabIndex = 14;
            this.lblBairro.Text = "Bairro";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(59, 212);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(527, 26);
            this.txtEndereco.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Endereço";
            // 
            // mkbTelefone
            // 
            this.mkbTelefone.Location = new System.Drawing.Point(419, 145);
            this.mkbTelefone.Mask = "(00) 00000-0000";
            this.mkbTelefone.Name = "mkbTelefone";
            this.mkbTelefone.Size = new System.Drawing.Size(130, 26);
            this.mkbTelefone.TabIndex = 4;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(56, 59);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 18);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(416, 124);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(66, 18);
            this.lblTelefone.TabIndex = 10;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(180, 59);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 18);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(60, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(332, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(183, 82);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(513, 26);
            this.txtNome.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(57, 122);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 18);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-mail";
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpbMedico);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPacientes";
            this.Load += new System.EventHandler(this.frmPacientes_Load);
            this.panel1.ResumeLayout(false);
            this.gpbMedico.ResumeLayout(false);
            this.gpbMedico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gpbMedico;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mkbTelefone;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mkbCEP;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox mkbCPF;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnCarregaEndereco;
    }
}