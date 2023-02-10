
namespace ConsultorioMedico
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.btnConvenios = new System.Windows.Forms.Button();
            this.btnAgendas = new System.Windows.Forms.Button();
            this.btnExames = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(566, 512);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(140, 33);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.Image = ((System.Drawing.Image)(resources.GetObject("btnPacientes.Image")));
            this.btnPacientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPacientes.Location = new System.Drawing.Point(533, 49);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(196, 201);
            this.btnPacientes.TabIndex = 7;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnMedicos
            // 
            this.btnMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicos.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicos.Image")));
            this.btnMedicos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMedicos.Location = new System.Drawing.Point(297, 49);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(196, 201);
            this.btnMedicos.TabIndex = 8;
            this.btnMedicos.Text = "Médicos";
            this.btnMedicos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMedicos.UseVisualStyleBackColor = true;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // btnConvenios
            // 
            this.btnConvenios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvenios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvenios.Image = ((System.Drawing.Image)(resources.GetObject("btnConvenios.Image")));
            this.btnConvenios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConvenios.Location = new System.Drawing.Point(297, 276);
            this.btnConvenios.Name = "btnConvenios";
            this.btnConvenios.Size = new System.Drawing.Size(196, 201);
            this.btnConvenios.TabIndex = 11;
            this.btnConvenios.Text = "Convênios";
            this.btnConvenios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConvenios.UseVisualStyleBackColor = true;
            this.btnConvenios.Click += new System.EventHandler(this.btnConvenios_Click);
            // 
            // btnAgendas
            // 
            this.btnAgendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendas.Image = ((System.Drawing.Image)(resources.GetObject("btnAgendas.Image")));
            this.btnAgendas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgendas.Location = new System.Drawing.Point(533, 276);
            this.btnAgendas.Name = "btnAgendas";
            this.btnAgendas.Size = new System.Drawing.Size(196, 201);
            this.btnAgendas.TabIndex = 10;
            this.btnAgendas.Text = "Agendas";
            this.btnAgendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgendas.UseVisualStyleBackColor = true;
            this.btnAgendas.Click += new System.EventHandler(this.btnAgendas_Click);
            // 
            // btnExames
            // 
            this.btnExames.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExames.Image = ((System.Drawing.Image)(resources.GetObject("btnExames.Image")));
            this.btnExames.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExames.Location = new System.Drawing.Point(53, 276);
            this.btnExames.Name = "btnExames";
            this.btnExames.Size = new System.Drawing.Size(196, 201);
            this.btnExames.TabIndex = 9;
            this.btnExames.Text = "Exames";
            this.btnExames.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExames.UseVisualStyleBackColor = true;
            this.btnExames.Click += new System.EventHandler(this.btnExames_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultas.Image")));
            this.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultas.Location = new System.Drawing.Point(53, 49);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(196, 201);
            this.btnConsultas.TabIndex = 12;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnConvenios);
            this.Controls.Add(this.btnAgendas);
            this.Controls.Add(this.btnExames);
            this.Controls.Add(this.btnMedicos);
            this.Controls.Add(this.btnPacientes);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Button btnConvenios;
        private System.Windows.Forms.Button btnAgendas;
        private System.Windows.Forms.Button btnExames;
        private System.Windows.Forms.Button btnConsultas;
    }
}