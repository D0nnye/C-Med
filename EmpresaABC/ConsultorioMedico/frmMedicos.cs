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


namespace ConsultorioMedico
{
    public partial class frmMedicos : Form
    {

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmMedicos()
        {
            InitializeComponent();
        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

            carregaCombo();
        }
        private void carregaCombo()
        {
            cbbEspecialidade.Items.Add("Clinico Geral");
            cbbEspecialidade.Items.Add("Urologista");
            cbbEspecialidade.Items.Add("Psiquiatra");
            cbbEspecialidade.Items.Add("Pediatra");
            cbbEspecialidade.Items.Add("Psicologo");

        }
        private void btnCadEsp_Click(object sender, EventArgs e)
        {
            frmEspecialidades abrir = new frmEspecialidades();
            abrir.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal voltar = new frmMenuPrincipal();
            voltar.Show();
            this.Hide();
        }
    }
    }

