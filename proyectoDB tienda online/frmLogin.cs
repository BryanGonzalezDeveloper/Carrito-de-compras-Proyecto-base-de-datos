using proyectoDB_tienda_online.DB;
using System;
using System.Windows.Forms;
namespace proyectoDB_tienda_online
{
    public partial class frmLogin : Form
    {
        MetodosDB objDB = new MetodosDB();
        string nombreUsuario=string.Empty;
        public frmLogin()
        {
            InitializeComponent();
            objDB.miDelegado = setPermisosAdmin;
            objDB.DelAsignarNombre = setNombreUsuario;
        }
        public frmRegistrarse pantallaRegistrarse = null;
        FrmMenuPrincipal frmPrincipal = null;
        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcontraseña.Text))
                txtcontraseña.PasswordChar = '\0';
            else
                txtcontraseña.PasswordChar = '*';
        }

        private void btnCerrarLogin(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        bool flag = false;
        void setPermisosAdmin(bool tienePermiso)
        {
            if (tienePermiso)
                flag = true;
            else
                flag = false;
        }
        void setNombreUsuario(string txt)
        {
            nombreUsuario = txt;
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (objDB.obtenerUsuario(txtCorreo.Text, txtcontraseña.Text))
            {
                if (frmPrincipal != null)
                {
                    frmPrincipal = null;
                }
                frmPrincipal = new FrmMenuPrincipal();
                frmPrincipal.lblUsuario.Text = nombreUsuario;
                frmPrincipal.Correo = txtCorreo.Text;
                frmPrincipal.Contrasena = txtcontraseña.Text;
                frmPrincipal.pantallaLogin = this;
                if (cboTipoUsuario.SelectedIndex==0)
                {
                    frmPrincipal.EsAdmin = false;
                    this.Hide();
                    frmPrincipal.Show();
                }
                else if(cboTipoUsuario.SelectedIndex==1)
                {
                    if(flag)
                    {
                        frmPrincipal.EsAdmin = true;
                        this.Hide();
                        frmPrincipal.Show();
                    }
                    else
                        MessageBox.Show("El usuario no tiene permisos de administrador\nverifique sus datos","No se pudo iniciar sesion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                   
               

            }
            else
            {
                MessageBox.Show("Datos no encontrados\nVerifique que sus datos sean correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pantallaRegistrarse != null)
            {
                this.Hide();
                pantallaRegistrarse.pantallaLogin = this;
                pantallaRegistrarse.Show();
            }
            else
            {
                pantallaRegistrarse = new frmRegistrarse();
                pantallaRegistrarse.pantallaLogin = this;
                this.Hide();
                pantallaRegistrarse.Show();
            }
        }
    }
}
