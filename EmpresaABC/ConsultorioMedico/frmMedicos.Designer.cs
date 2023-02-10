
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.panel1.SuspendLayout();
            this.gpbMedico.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, 460);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 97);
            this.panel1.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(626, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 65);
            this.button5.TabIndex = 4;
            this.button5.Text = "&Voltar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(471, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "&Pesquisar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(315, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "&Excluir";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(159, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Alterar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(3, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Cadastrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblCrm
            // 
            this.lblCrm.AutoSize = true;
            this.lblCrm.Location = new System.Drawing.Point(56, 59);
            this.lblCrm.Name = "lblCrm";
            this.lblCrm.Size = new System.Drawing.Size(45, 20);
            this.lblCrm.TabIndex = 2;
            this.lblCrm.Text = "CRM";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(239, 82);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(457, 26);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(236, 59);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.Location = new System.Drawing.Point(56, 231);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(108, 20);
            this.lblEspecialidade.TabIndex = 6;
            this.lblEspecialidade.Text = "Especialidade";
            // 
            // cbbEspecialidade
            // 
            this.cbbEspecialidade.FormattingEnabled = true;
            this.cbbEspecialidade.Location = new System.Drawing.Point(59, 254);
            this.cbbEspecialidade.Name = "cbbEspecialidade";
            this.cbbEspecialidade.Size = new System.Drawing.Size(240, 28);
            this.cbbEspecialidade.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(58, 163);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(370, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(55, 140);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-mail";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(450, 139);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(71, 20);
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
            this.gpbMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMedico.Location = new System.Drawing.Point(12, 12);
            this.gpbMedico.Name = "gpbMedico";
            this.gpbMedico.Size = new System.Drawing.Size(760, 442);
            this.gpbMedico.TabIndex = 0;
            this.gpbMedico.TabStop = false;
            this.gpbMedico.Text = "Informações do Médico";
            // 
            // btnCadEsp
            // 
            this.btnCadEsp.Image = ((System.Drawing.Image)(resources.GetObject("btnCadEsp.Image")));
            this.btnCadEsp.Location = new System.Drawing.Point(320, 253);
            this.btnCadEsp.Name = "btnCadEsp";
            this.btnCadEsp.Size = new System.Drawing.Size(52, 28);
            this.btnCadEsp.TabIndex = 11;
            this.btnCadEsp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadEsp.UseVisualStyleBackColor = true;
            this.btnCadEsp.Click += new System.EventHandler(this.btnCadEsp_Click);
            // 
            // mkbCrm
            // 
            this.mkbCrm.Location = new System.Drawing.Point(60, 82);
            this.mkbCrm.Mask = "00000000";
            this.mkbCrm.Name = "mkbCrm";
            this.mkbCrm.Size = new System.Drawing.Size(84, 26);
            this.mkbCrm.TabIndex = 1;
            // 
            // mkbTelefone
            // 
            this.mkbTelefone.Location = new System.Drawing.Point(454, 163);
            this.mkbTelefone.Mask = "(00) 00000-0000";
            this.mkbTelefone.Name = "mkbTelefone";
            this.mkbTelefone.Size = new System.Drawing.Size(242, 26);
            this.mkbTelefone.TabIndex = 4;
            // 
            // frmMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpbMedico);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMedicos";
            this.Load += new System.EventHandler(this.frmMedicos_Load);
            this.panel1.ResumeLayout(false);
            this.gpbMedico.ResumeLayout(false);
            this.gpbMedico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
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
    }
}