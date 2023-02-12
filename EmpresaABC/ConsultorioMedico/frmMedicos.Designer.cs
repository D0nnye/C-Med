
namespace ConsultorioMedico
{
    partial class frmMedicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicos));
            this.lblCrm = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.cbbEspecialidade = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.gpbMedico = new System.Windows.Forms.GroupBox();
            this.btnCadEsp = new System.Windows.Forms.Button();
            this.mkbCrm = new System.Windows.Forms.MaskedTextBox();
            this.mkbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gpbMedico.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCrm
            // 
            this.lblCrm.AutoSize = true;
            this.lblCrm.Location = new System.Drawing.Point(56, 64);
            this.lblCrm.Name = "lblCrm";
            this.lblCrm.Size = new System.Drawing.Size(44, 18);
            this.lblCrm.TabIndex = 2;
            this.lblCrm.Text = "CRM";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(239, 88);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(457, 26);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(236, 64);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 18);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.Location = new System.Drawing.Point(56, 249);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(109, 18);
            this.lblEspecialidade.TabIndex = 6;
            this.lblEspecialidade.Text = "Especialidade";
            // 
            // cbbEspecialidade
            // 
            this.cbbEspecialidade.FormattingEnabled = true;
            this.cbbEspecialidade.Location = new System.Drawing.Point(59, 274);
            this.cbbEspecialidade.Name = "cbbEspecialidade";
            this.cbbEspecialidade.Size = new System.Drawing.Size(240, 26);
            this.cbbEspecialidade.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(58, 176);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(370, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(55, 151);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 18);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-mail";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(450, 150);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(66, 18);
            this.lblTelefone.TabIndex = 10;
            this.lblTelefone.Text = "Telefone";
            // 
            // gpbMedico
            // 
            this.gpbMedico.Controls.Add(this.btnCadEsp);
            this.gpbMedico.Controls.Add(this.mkbCrm);
            this.gpbMedico.Controls.Add(this.mkbTelefone);
            this.gpbMedico.Controls.Add(this.lblCrm);
            this.gpbMedico.Controls.Add(this.lblTelefone);
            this.gpbMedico.Controls.Add(this.lblNome);
            this.gpbMedico.Controls.Add(this.txtEmail);
            this.gpbMedico.Controls.Add(this.txtNome);
            this.gpbMedico.Controls.Add(this.lblEmail);
            this.gpbMedico.Controls.Add(this.lblEspecialidade);
            this.gpbMedico.Controls.Add(this.cbbEspecialidade);
            this.gpbMedico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMedico.Location = new System.Drawing.Point(12, 13);
            this.gpbMedico.Name = "gpbMedico";
            this.gpbMedico.Size = new System.Drawing.Size(760, 476);
            this.gpbMedico.TabIndex = 0;
            this.gpbMedico.TabStop = false;
            this.gpbMedico.Text = "Informações do Médico";
            // 
            // btnCadEsp
            // 
            this.btnCadEsp.Image = ((System.Drawing.Image)(resources.GetObject("btnCadEsp.Image")));
            this.btnCadEsp.Location = new System.Drawing.Point(320, 272);
            this.btnCadEsp.Name = "btnCadEsp";
            this.btnCadEsp.Size = new System.Drawing.Size(52, 30);
            this.btnCadEsp.TabIndex = 11;
            this.btnCadEsp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadEsp.UseVisualStyleBackColor = true;
            this.btnCadEsp.Click += new System.EventHandler(this.btnCadEsp_Click);
            // 
            // mkbCrm
            // 
            this.mkbCrm.Location = new System.Drawing.Point(60, 88);
            this.mkbCrm.Mask = "00000000";
            this.mkbCrm.Name = "mkbCrm";
            this.mkbCrm.Size = new System.Drawing.Size(84, 26);
            this.mkbCrm.TabIndex = 1;
            // 
            // mkbTelefone
            // 
            this.mkbTelefone.Location = new System.Drawing.Point(454, 176);
            this.mkbTelefone.Mask = "(00) 00000-0000";
            this.mkbTelefone.Name = "mkbTelefone";
            this.mkbTelefone.Size = new System.Drawing.Size(242, 26);
            this.mkbTelefone.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Location = new System.Drawing.Point(12, 495);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 104);
            this.panel1.TabIndex = 12;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(617, 16);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(140, 70);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(461, 16);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(150, 70);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(305, 16);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(150, 70);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(149, 16);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(150, 70);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(3, 16);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(141, 70);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // frmMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gpbMedico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMedicos";
            this.Load += new System.EventHandler(this.frmMedicos_Load);
            this.gpbMedico.ResumeLayout(false);
            this.gpbMedico.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCrm;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEspecialidade;
        private System.Windows.Forms.ComboBox cbbEspecialidade;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.GroupBox gpbMedico;
        private System.Windows.Forms.MaskedTextBox mkbCrm;
        private System.Windows.Forms.MaskedTextBox mkbTelefone;
        private System.Windows.Forms.Button btnCadEsp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
    }
}