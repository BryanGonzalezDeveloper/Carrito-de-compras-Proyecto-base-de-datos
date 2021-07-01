using proyectoDB_tienda_online.DB;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace proyectoDB_tienda_online
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        MetodosDB objDB = new MetodosDB();

        #region Categorias
        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            if (actualizarCategoria)
            {
                objDB.editarCategoria(Int32.Parse(txtIDCategoria.Text), txtDescripcionCategoria.Text, true);
                actualizarCategoria = false;
            }
            else
            {
                objDB.agregarCategoria(txtDescripcionCategoria.Text);
            }
            dgvCategorias.DataSource = objDB.listadoCategorias();
            txtDescripcionCategoria.Text = string.Empty;
            pnlActualizarCategoria.Visible = false;
        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            txtDescripcionCategoria.Text = string.Empty;
            txtIDCategoria.Text = string.Empty;
            pnlActualizarCategoria.Visible = false;
            actualizarCategoria = false;
        }

        private void pbRefreshCategoria_Click(object sender, EventArgs e)
        {
            dgvCategorias.DataSource = objDB.listadoCategorias();
        }

        private void pbAgregarCategoria_Click(object sender, EventArgs e)
        {
            pnlActualizarCategoria.Visible = true;

        }
        bool actualizarCategoria = false;
        private void pbActualizarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count == 1)
            {
                actualizarCategoria = true;
                txtDescripcionCategoria.Text = dgvCategorias.CurrentRow.Cells[1].Value.ToString();
                txtIDCategoria.Text = dgvCategorias.CurrentRow.Cells[0].Value.ToString();
                pnlActualizarCategoria.Visible = true;
            }
            else
                MessageBox.Show("Seleccione una fila.");
        }

        private void pbEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Segur@ que desea eliminar\nla categoria seleccionada", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtIDCategoria.Text = dgvCategorias.CurrentRow.Cells[0].Value.ToString();
                    objDB.editarCategoria(Int32.Parse(txtIDCategoria.Text), dgvCategorias.CurrentRow.Cells[1].Value.ToString(), false);
                    dgvCategorias.DataSource = objDB.listadoCategorias();
                    txtIDCategoria.Text = string.Empty;
                }
            }
        }
        #endregion

        #region Marcas
        private void pbRefreshMarca_Click(object sender, EventArgs e)
        {
            dgvMarcas.DataSource = objDB.listadoMarcas();
        }

        private void pbAgregarMarca_Click(object sender, EventArgs e)
        {
            pnlEditarMarca.Visible = true;
            txtDescripcionMarca.Focus();
        }
        bool actualizarMarca = false;
        private void pbEditarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.SelectedRows.Count == 1)
            {
                actualizarMarca = true;
                txtDescripcionMarca.Text = dgvMarcas.CurrentRow.Cells[1].Value.ToString();
                txtIdMarca.Text = dgvMarcas.CurrentRow.Cells[0].Value.ToString();
                pnlEditarMarca.Visible = true;
            }

        }

        private void pbEliminarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Segur@ que desea eliminar\nla marca seleccionada", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtIdMarca.Text = dgvMarcas.CurrentRow.Cells[0].Value.ToString();
                    objDB.editarMarca(Int32.Parse(txtIdMarca.Text), dgvMarcas.CurrentRow.Cells[1].Value.ToString(), false);
                    dgvMarcas.DataSource = objDB.listadoMarcas();
                    txtIdMarca.Text = string.Empty;
                }
            }
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            if (actualizarMarca)
            {
                objDB.editarMarca(Int32.Parse(txtIdMarca.Text), txtDescripcionMarca.Text, true);
            }
            else
            {
                objDB.agregarMarca(txtDescripcionMarca.Text);
            }
            actualizarMarca = false;
            txtDescripcionMarca.Text = string.Empty;
            txtIdMarca.Text = string.Empty;
            dgvMarcas.DataSource = objDB.listadoMarcas();
            pnlEditarMarca.Visible = false;
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            actualizarMarca = false;
            txtDescripcionMarca.Text = string.Empty;
            txtIdMarca.Text = string.Empty;
            pnlEditarMarca.Visible = false;
        }
        #endregion

        #region Productos
        bool actualizarProducto = false;
        private void btnRefreshProducto_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = objDB.listadoProductos();
            actualizarComboProducto();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            pnlProductos.Visible = true;
            actualizarComboProducto();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 1)
            {
                actualizarComboProducto();
                actualizarProducto = true;
                pnlProductos.Visible = true;

                txtIdProducto.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                txtNombreProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                txtDescripcionProducto.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
                cboMarca.SelectedIndex = cboMarca.Items.IndexOf(dgvProductos.CurrentRow.Cells[10].Value.ToString());
                cboCategoria.SelectedIndex = 
                    cboCategoria.Items.IndexOf(dgvProductos.CurrentRow.Cells[11].Value.ToString());
                txtPrecioProducto.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
                txtStockProducto.Text = dgvProductos.CurrentRow.Cells[6].Value.ToString();
                txtPathImagenProducto.Text= dgvProductos.CurrentRow.Cells[7].Value.ToString();
                pbImagenProducto.Image = Image.FromFile(txtPathImagenProducto.Text);


            }
            else
                MessageBox.Show("Seleccione al menos una fila");


        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 1)
            {
                int id = Int32.Parse(dgvProductos.CurrentRow.Cells[0].Value.ToString());
                string nombre = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                string descripcion = dgvProductos.CurrentRow.Cells[2].Value.ToString();
                string marca = dgvProductos.CurrentRow.Cells[10].Value.ToString();
                string categoria = dgvProductos.CurrentRow.Cells[11].Value.ToString();
                double precio = Int32.Parse(dgvProductos.CurrentRow.Cells[5].Value.ToString());
                int stock = Int32.Parse(dgvProductos.CurrentRow.Cells[6].Value.ToString());
                objDB.editarProducto(id, nombre, descripcion, marca, categoria, precio, stock, false);
                dgvProductos.DataSource = objDB.listadoProductos();
                MessageBox.Show("Producto inhabilitado correctamente");
            }
        }

        private void btnPathImagenProducto_Click(object sender, EventArgs e)
        {
            if (op.ShowDialog() == DialogResult.OK)
            {
                txtPathImagenProducto.Text = op.FileName;
                pbImagenProducto.Image = Image.FromFile(op.FileName);
            }
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {

            if (actualizarProducto)
            {
                objDB.editarProducto(Int32.Parse(txtIdProducto.Text), txtNombreProducto.Text, txtDescripcionProducto.Text, cboMarca.Text, cboCategoria.Text, Double.Parse(txtPrecioProducto.Text), Int32.Parse(txtStockProducto.Text), true);
            }
            else
            {
                objDB.agregarProducto(txtNombreProducto.Text, txtDescripcionProducto.Text, cboMarca.Text, cboCategoria.Text, Double.Parse(txtPrecioProducto.Text), Int32.Parse(txtStockProducto.Text), txtPathImagenProducto.Text);
            }
            dgvProductos.DataSource = objDB.listadoProductos();
            limpiarControlesProductos();
            pnlProductos.Visible = false;
            actualizarProducto = false;
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            limpiarControlesProductos();
            pnlProductos.Visible = false;
            actualizarProducto = false;
        }

        void limpiarControlesProductos()
        {
            txtNombreProducto.Text = string.Empty;
            txtDescripcionProducto.Text = string.Empty;
            txtPrecioProducto.Text = string.Empty;
            txtStockProducto.Text = string.Empty;
            txtPathImagenProducto.Text = string.Empty;
            pbImagenProducto.Image = null;
            txtIdProducto.Text = string.Empty;
        }
        void actualizarComboProducto()
        {
            cboCategoria.DataSource = (from cat in objDB.listaCategoriaUsuarios().AsEnumerable() select cat.Field<string>(1)).ToList();
            cboMarca.DataSource = (from marca in objDB.listaMarcasUsuarios().AsEnumerable() select marca.Field<string>(1)).ToList();
        }

        #endregion

        #region REPORTES
        ClsReportes objReportes=new ClsReportes();
        private void rbTopCaros_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTopCaros.Checked)
                dgvReportes.DataSource = objReportes.top3ProductosCaros();
        }

        private void rbTopBaratos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTopBaratos.Checked)
                dgvReportes.DataSource = objReportes.top3ProductosBaratos();

        }

        private void rbMayorStock_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMayorStock.Checked)
                dgvReportes.DataSource = objReportes.ProductoMayorStock();
        }

        private void rbMenorStock_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMenorStock.Checked)
                dgvReportes.DataSource = objReportes.ProductoMenorStock();
        }

        private void rbPromedioVentas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPromedioVentas.Checked)
                dgvReportes.DataSource = objReportes.promedioVentas();
        }

        private void rbCategoriaSinArticulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCategoriaSinArticulo.Checked)
                dgvReportes.DataSource = objReportes.categoriaSinArticulo();
        }
        #endregion

    }
}
