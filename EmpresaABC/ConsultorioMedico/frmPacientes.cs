using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
//Correio
using Correios.Net;


namespace ConsultorioMedico
{
    public partial class frmPacientes : Form
    {

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            mkbCPF.Enabled = false;
            mkbCEP.Enabled = false;
            mkbTelefone.Enabled = false;
            cbbEstado.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }

        public void habilitarCampos()
        {
            txtCodigo.Enabled = true;
            txtNome.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            mkbCPF.Enabled = true;
            mkbCEP.Enabled = true;
            mkbTelefone.Enabled = true;
            cbbEstado.Enabled = true;
            btnCadastrar.Enabled = true;
            btnLimpar.Enabled = true;
            txtNome.Focus();
        }

        public void limparCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            mkbCPF.Text = "";
            mkbCEP.Text = "";
            mkbTelefone.Text = "";
            cbbEstado.Text = "";
        }
        //Metodo para carregar a ComboBox
        public void carregarComboBox()
        {
            cbbEstado.Items.Add("SP");
            cbbEstado.Items.Add("RJ");
            cbbEstado.Items.Add("BH");
            cbbEstado.Items.Add("BA");
            cbbEstado.Items.Add("RN");
        }
        //Construtor da classe
        public frmPacientes()
        {
            InitializeComponent();
            desabilitarCampos();
            carregarComboBox();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal voltar = new frmMenuPrincipal();
            voltar.Show();
            this.Hide();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Executando o método verificarCampo
            verificarCampo();
        }

        //Criando metodo para verificar campo vazio
        public void verificarCampo()
        {
            //if (txtNome.Text == "")
            //{
            //    MessageBox.Show("Inserir valores");
            //}

            if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") 
                || mkbCPF.Text.Equals("   .   .   -") 
                || mkbTelefone.Text.Equals("(  )      -") 
                || mkbCEP.Text.Equals("     -")
                || txtBairro.Text.Equals("")
                || txtCidade.Text.Equals("")
                || cbbEstado.Text.Equals(""))

            {
                MessageBox.Show("Inserir valores", "Mensagem do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Cadastrado com sucesso","Mensagem do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                desabilitarCampos();
                limparCampos();
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            txtNome.Focus();
        }

        private void btnCarregaEndereco_Click(object sender, EventArgs e)
        {
            Address add;
            add = SearchZip.GetAddress(mkbCEP.Text, 1000);

            txtEndereco.Text = add.Street;
            txtBairro.Text = add.District;
            txtCidade.Text = add.City;
            cbbEstado.Text = add.State;
        }
    }
}
