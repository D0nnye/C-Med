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
    public partial class frmMenuPrincipal : Form
    {

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin voltar = new frmLogin();
            voltar.Show();
            this.Hide();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            frmConsultas abrir = new frmConsultas();
            abrir.Show();
            this.Hide();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            frmMedicos abrir = new frmMedicos();
            abrir.Show();
            this.Hide();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes abrir = new frmPacientes();
            abrir.Show();
            this.Hide();
        }

        private void btnExames_Click(object sender, EventArgs e)
        {
            frmExames abrir = new frmExames();
            abrir.Show();
            this.Hide();
        }

        private void btnConvenios_Click(object sender, EventArgs e)
        {
            frmConvenio abrir = new frmConvenio();
            abrir.Show();
            this.Hide();
        }

        private void btnAgendas_Click(object sender, EventArgs e)
        {
            frmAgendas abrir = new frmAgendas();
            abrir.Show();
            this.Hide();
        }
    }
}
