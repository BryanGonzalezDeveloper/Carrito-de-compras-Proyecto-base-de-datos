using Bunifu.UI.WinForms;
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
    public partial class frmRegistrarse : Form
    {
        public frmRegistrarse()
        {
            InitializeComponent();
        }
        MetodosDB objDB = new MetodosDB();
       public frmLogin pantallaLogin = null;
        void hintText(BunifuTextBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text))
                txt.PasswordChar = '\0';
            else
                txt.PasswordChar = '*';
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            hintText(txtContraseña);
            if (string.IsNullOrEmpty(txtContraseña.Text) == false && string.IsNullOrEmpty(txtConfirmarContraseña.Text) == false && txtConfirmarContraseña.Text.Equals(txtContraseña.Text)==false)          
            {
                pbCorrecto.Visible = false;
                pbErroneo.Visible = true;
            }
            else if (string.IsNullOrEmpty(txtContraseña.Text) == false && string.IsNullOrEmpty(txtConfirmarContraseña.Text) == false && txtConfirmarContraseña.Text.Equals(txtContraseña.Text))
            {
                pbCorrecto.Visible = true;
                pbErroneo.Visible = false;
            }
            if (string.IsNullOrEmpty(txtContraseña.Text)  && string.IsNullOrEmpty(txtConfirmarContraseña.Text))
            {
                pbCorrecto.Visible = false;
                pbErroneo.Visible = false;
            }
        }

        private void txtConfirmarContraseña_TextChanged(object sender, EventArgs e)
        {
            hintText(txtConfirmarContraseña);
            if(string.IsNullOrEmpty(txtConfirmarContraseña.Text)==false && txtConfirmarContraseña.Text.Equals(txtContraseña.Text))
            {
                pbCorrecto.Visible = true;
                pbErroneo.Visible = false;
            }
            else
            {
                pbCorrecto.Visible = false;
                pbErroneo.Visible = true;
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if(pbCorrecto.Visible)
            {
                if(objDB.insertarUsuario(txtNombre.Text,txtApellido.Text,txtCorreo.Text,txtContraseña.Text))
                {
                    FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
                    frmMenu.EsAdmin = false;
                    frmMenu.lblUsuario.Text = txtNombre.Text;
                    frmMenu.Contrasena = txtConfirmarContraseña.Text;
                    frmMenu.Correo = txtCorreo.Text;
                    this.Hide();
                    frmMenu.Show();
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            pantallaLogin.pantallaRegistrarse = this;
            pantallaLogin.Show();
        }
    }
}
