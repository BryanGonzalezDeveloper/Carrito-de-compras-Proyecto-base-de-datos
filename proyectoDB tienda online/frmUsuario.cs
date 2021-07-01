using proyectoDB_tienda_online.DB;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace proyectoDB_tienda_online
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }
      public  int idUsuario;
        Producto[] arrProducto = null;
        void setArrProductos(DataTable dt)
        {
            if (dt != null)
            {
                arrProducto = new Producto[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    arrProducto[i] = new Producto();
                    arrProducto[i].ID_usuario = idUsuario;
                    arrProducto[i].ID_producto = Int32.Parse(dt.Rows[i][0].ToString());
                    arrProducto[i].NombreProducto = dt.Rows[i][1].ToString();
                    arrProducto[i].CostoProducto = Double.Parse(dt.Rows[i][5].ToString());
                    arrProducto[i].NombreProducto = dt.Rows[i][1].ToString();
                    arrProducto[i].ImagenProducto = Image.FromFile(dt.Rows[i][7].ToString());
                    flowLayout.Controls.Add(arrProducto[i]);

                }
            }
        }
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            setArrProductos(objDB.listaProductoUsuarios());
            timer1.Start();
           
            
        }
        MetodosDB objDB = new MetodosDB();

        private void btnRefreshProducto_Click(object sender, EventArgs e)
        {
            dgvUsuario_productos.DataSource = objDB.listaProductoUsuarios();
        }

        private void btnListadoMarcas_Click(object sender, EventArgs e)
        {
            dgvUsuario_marcas.DataSource = objDB.listaMarcasUsuarios();

        }

        private void btnListadoCategorias_Click(object sender, EventArgs e)
        {
            dgvUsuario_Categorias.DataSource = objDB.listaCategoriaUsuarios();
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            flowLayout.Controls.Clear();
            if(arrProducto!=null)
            {
                var arr = (from prod in arrProducto
                        where prod.NombreProducto.ToLower().StartsWith(txtBuscarProducto.Text.ToLower())
                        select prod).ToArray();
                if(arr!=null)
                {
                    foreach (var p in arr)
                    {
                        flowLayout.Controls.Add(p);
                    }
                }
               
            }

        }
        private void pbVerCarrito_Click(object sender, EventArgs e)
        {
            dgvVerCarrito.DataSource = objDB.verCarrito(idUsuario);
            pagesUsuario.SetPage("ver carrito");
        }

        private void btnVolverHome_Click(object sender, EventArgs e)
        {
            pagesUsuario.SetPage("HOME");
        }
        DataTable dtCompra = null;
        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Segur@ que desea continuar con la transaccion?","CONFIRMAR COMPRA",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                dtCompra = (DataTable)dgvVerCarrito.DataSource;
                if(dtCompra!=null)
                {
                    int totalArticulos = 0;
                    double costoTotal = 0;
                    for (int i = 0; i < dtCompra.Rows.Count; i++)
                    {
                        totalArticulos += Int32.Parse(dtCompra.Rows[i][4].ToString());
                        costoTotal += Double.Parse(dtCompra.Rows[i][5].ToString());
                    }
                    lblTotalApagar.Text = costoTotal.ToString();
                    lblTotalArticulos.Text = totalArticulos.ToString();
                }
                pagesUsuario.SetPage("confirmar compra");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dddd MMMM dd, yyyy");
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                objDB.realizarCompra(idUsuario,Int32.Parse(lblTotalArticulos.Text), double.Parse(lblTotalApagar.Text), txtContacto.Text, txtTelefono.Text, txtDireccion.Text);
                for (int i = 0; i < dtCompra.Rows.Count; i++)
                {
                    int cantidad = Int32.Parse(dtCompra.Rows[i][4].ToString());
                    double precio = Double.Parse(dtCompra.Rows[i][5].ToString());
                    objDB.detalleCompra(idUsuario, Int32.Parse(dtCompra.Rows[i][1].ToString()), cantidad, cantidad * precio);
                }
                objDB.eliminarCarrito(idUsuario);
                limpiarControles();
                MessageBox.Show("Compra realizada con exito");
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error:\n"+ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        void limpiarControles()
        {
            txtContacto.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            lblTotalApagar.Text = string.Empty;
            lblTotalArticulos.Text = string.Empty;
           
        }

        private void btnvaciarCarrito_Click(object sender, EventArgs e)
        {
            DataTable vaciarCarrito = (DataTable)dgvVerCarrito.DataSource;
            if(vaciarCarrito!=null)
            {
                if (MessageBox.Show("Segur@ que desea vaciar el carrito?\nLos articulos seran eliminados del carrito","Vaciar carrito",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    objDB.eliminarCarrito(idUsuario);

                }
            }
        }
    }
}
