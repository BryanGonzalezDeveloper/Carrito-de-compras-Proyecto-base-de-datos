using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoDB_tienda_online.DB;
namespace proyectoDB_tienda_online
{
    public partial class FrmMenuPrincipal : Form
    {
        public bool EsAdmin { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        frmAdmin pantallaAdmin = null;
        frmUsuario pantallaUsuario = null;
        public frmLogin pantallaLogin = null;
        MetodosDB db = new MetodosDB();
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (EsAdmin)
            {
                pantallaAdmin = new frmAdmin();
                activarView(pantallaAdmin);
            }

            else
            {
                pantallaUsuario = new frmUsuario();
                pantallaUsuario.idUsuario = db.obtenerIDusuario(Contrasena, Correo);
                activarView(pantallaUsuario);
            }

        }

        void activarView(Form view)
        {
            
            if(EsAdmin)
            {
                pnlAdmi.Visible = true;
                pnlUsuario.Visible = false;
                ActivarFrm(view, pnlContenedor);
            }
            else
            {
                pnlAdmi.Visible = false;
                pnlUsuario.Visible = true;
                ActivarFrm(view, pnlContenedor);

            }
         
        }
        private void ViewAdmin(object sender, EventArgs e)
        {
            pantallaAdmin.pagesAdmin.SetPage(((Guna2Button)sender).Text);
        }

        private void ViewUsuario(object sender, EventArgs e)
        {
            pantallaUsuario.pagesUsuario.SetPage(((Guna2Button)sender).Text);
        }

        private static Form formActiva = null;
        public static void ActivarFrm(Form formaHija, Panel panelMostrarFormulario)
        {
            if (formActiva != null)
                formActiva.Close();
            formActiva = formaHija;
            formaHija.TopLevel = false;
            formaHija.FormBorderStyle = FormBorderStyle.None;
            formaHija.Dock = DockStyle.Fill;
            panelMostrarFormulario.Controls.Add(formaHija);
            panelMostrarFormulario.Tag = formaHija;
            formaHija.BringToFront();
            formaHija.Show();

        }

        private void OcultarMenu(object sender, EventArgs e)
        {
            if (EsAdmin)
            {
                if (pnlAdmi.Visible)
                    pnlAdmi.Visible = false;
                else
                    pnlAdmi.Visible = true;
            }
            else
            {
                if (pnlUsuario.Visible)
                    pnlUsuario.Visible = false;
                else
                    pnlUsuario.Visible = true;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Segur@ que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                pantallaLogin.txtcontraseña.Text = string.Empty;
                pantallaLogin.Show();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Segur@ que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
