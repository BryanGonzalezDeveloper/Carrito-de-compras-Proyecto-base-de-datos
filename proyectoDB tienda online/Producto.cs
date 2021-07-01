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
    public partial class Producto : Bunifu.UI.WinForms.BunifuUserControl
    {
        public Producto()
        {
            InitializeComponent();
        }
        public Image ImagenProducto 
        {
            set
            {
                pbImagenProducto.Image = value;
            }
            get
            {
                return pbImagenProducto.Image;
            }
        }
        public double CostoProducto
        {
            set
            {
                lblCosto.Text = value.ToString();
            }
            get
            {
                return Double.Parse(lblCosto.Text);
            }
        }
        public string NombreProducto
        {
            set
            {
               lblNombreProducto.Text = value;
            }
            get
            {
                return lblNombreProducto.Text;
            }
        }
        int idProducto=-1;
        int idUsuario=-1;
        public void agregarCarrito(int idUsuario)
        {
            objDB.agregarAlCarrito(idUsuario, idProducto);
        }
        public int ID_producto { get { return idProducto; } set { idProducto = value; } }
        public int ID_usuario { get { return idUsuario; } set { idUsuario = value; } }
        MetodosDB objDB = new MetodosDB();
        
        private void pbCarrito_Click(object sender, EventArgs e)
        {
            try
            {
               
                objDB.agregarAlCarrito(idUsuario, idProducto);
                MessageBox.Show("Se agrego al carrito");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error:\n"+ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
