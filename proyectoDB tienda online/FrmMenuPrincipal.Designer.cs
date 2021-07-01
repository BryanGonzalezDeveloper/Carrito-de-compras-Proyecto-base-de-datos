
namespace proyectoDB_tienda_online
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new Guna.UI2.WinForms.Guna2Button();
            this.btnSalir = new Guna.UI2.WinForms.Guna2Button();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.btnUsuarioListadoCategoria = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsuarioListadoMarcas = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsuarioListadoProductos = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsuarioHome = new Guna.UI2.WinForms.Guna2Button();
            this.pnlAdmi = new System.Windows.Forms.Panel();
            this.btnAdminAjustes = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdminReportes = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdminProducto = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdminMarca = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdminCategoria = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblUsuario = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            this.pnlAdmi.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 39);
            this.panel1.TabIndex = 0;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(62, 10);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(625, 23);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "PROYECTO FINAL FUNDAMENTOS DE BASE DE DATOS- TIENDA ONLINE 2021";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyectoDB_tienda_online.Properties.Resources.shop;
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel2.Controls.Add(this.btnCerrarSesion);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.pnlUsuario);
            this.panel2.Controls.Add(this.pnlAdmi);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 533);
            this.panel2.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BorderRadius = 10;
            this.btnCerrarSesion.CheckedState.Parent = this.btnCerrarSesion;
            this.btnCerrarSesion.CustomImages.Parent = this.btnCerrarSesion;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(84)))), ((int)(((byte)(108)))));
            this.btnCerrarSesion.HoverState.Parent = this.btnCerrarSesion;
            this.btnCerrarSesion.Image = global::proyectoDB_tienda_online.Properties.Resources.logout;
            this.btnCerrarSesion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCerrarSesion.ImageSize = new System.Drawing.Size(28, 28);
            this.btnCerrarSesion.Location = new System.Drawing.Point(3, 467);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.PressedColor = System.Drawing.Color.Teal;
            this.btnCerrarSesion.ShadowDecoration.Parent = this.btnCerrarSesion;
            this.btnCerrarSesion.Size = new System.Drawing.Size(191, 30);
            this.btnCerrarSesion.TabIndex = 9;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCerrarSesion.TextOffset = new System.Drawing.Point(5, 0);
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BorderRadius = 10;
            this.btnSalir.CheckedState.Parent = this.btnSalir;
            this.btnSalir.CustomImages.Parent = this.btnSalir;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnSalir.HoverState.Parent = this.btnSalir;
            this.btnSalir.Image = global::proyectoDB_tienda_online.Properties.Resources.cancelar;
            this.btnSalir.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSalir.ImageSize = new System.Drawing.Size(28, 28);
            this.btnSalir.Location = new System.Drawing.Point(0, 503);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.PressedColor = System.Drawing.Color.Maroon;
            this.btnSalir.ShadowDecoration.Parent = this.btnSalir;
            this.btnSalir.Size = new System.Drawing.Size(200, 30);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSalir.TextOffset = new System.Drawing.Point(5, 0);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.btnUsuarioListadoCategoria);
            this.pnlUsuario.Controls.Add(this.btnUsuarioListadoMarcas);
            this.pnlUsuario.Controls.Add(this.btnUsuarioListadoProductos);
            this.pnlUsuario.Controls.Add(this.btnUsuarioHome);
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsuario.Location = new System.Drawing.Point(0, 283);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(200, 159);
            this.pnlUsuario.TabIndex = 6;
            // 
            // btnUsuarioListadoCategoria
            // 
            this.btnUsuarioListadoCategoria.BorderRadius = 10;
            this.btnUsuarioListadoCategoria.CheckedState.Parent = this.btnUsuarioListadoCategoria;
            this.btnUsuarioListadoCategoria.CustomImages.Parent = this.btnUsuarioListadoCategoria;
            this.btnUsuarioListadoCategoria.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUsuarioListadoCategoria.ForeColor = System.Drawing.Color.White;
            this.btnUsuarioListadoCategoria.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(84)))), ((int)(((byte)(108)))));
            this.btnUsuarioListadoCategoria.HoverState.Parent = this.btnUsuarioListadoCategoria;
            this.btnUsuarioListadoCategoria.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsuarioListadoCategoria.ImageSize = new System.Drawing.Size(28, 28);
            this.btnUsuarioListadoCategoria.Location = new System.Drawing.Point(6, 123);
            this.btnUsuarioListadoCategoria.Name = "btnUsuarioListadoCategoria";
            this.btnUsuarioListadoCategoria.PressedColor = System.Drawing.Color.Teal;
            this.btnUsuarioListadoCategoria.ShadowDecoration.Parent = this.btnUsuarioListadoCategoria;
            this.btnUsuarioListadoCategoria.Size = new System.Drawing.Size(191, 30);
            this.btnUsuarioListadoCategoria.TabIndex = 8;
            this.btnUsuarioListadoCategoria.Text = "Listado de categorias";
            this.btnUsuarioListadoCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsuarioListadoCategoria.TextOffset = new System.Drawing.Point(5, 0);
            this.btnUsuarioListadoCategoria.Click += new System.EventHandler(this.ViewUsuario);
            // 
            // btnUsuarioListadoMarcas
            // 
            this.btnUsuarioListadoMarcas.BorderRadius = 10;
            this.btnUsuarioListadoMarcas.CheckedState.Parent = this.btnUsuarioListadoMarcas;
            this.btnUsuarioListadoMarcas.CustomImages.Parent = this.btnUsuarioListadoMarcas;
            this.btnUsuarioListadoMarcas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUsuarioListadoMarcas.ForeColor = System.Drawing.Color.White;
            this.btnUsuarioListadoMarcas.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(84)))), ((int)(((byte)(108)))));
            this.btnUsuarioListadoMarcas.HoverState.Parent = this.btnUsuarioListadoMarcas;
            this.btnUsuarioListadoMarcas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsuarioListadoMarcas.ImageSize = new System.Drawing.Size(28, 28);
            this.btnUsuarioListadoMarcas.Location = new System.Drawing.Point(6, 84);
            this.btnUsuarioListadoMarcas.Name = "btnUsuarioListadoMarcas";
            this.btnUsuarioListadoMarcas.PressedColor = System.Drawing.Color.Teal;
            this.btnUsuarioListadoMarcas.ShadowDecoration.Parent = this.btnUsuarioListadoMarcas;
            this.btnUsuarioListadoMarcas.Size = new System.Drawing.Size(191, 30);
            this.btnUsuarioListadoMarcas.TabIndex = 7;
            this.btnUsuarioListadoMarcas.Text = "Listado de marcas";
            this.btnUsuarioListadoMarcas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsuarioListadoMarcas.TextOffset = new System.Drawing.Point(5, 0);
            this.btnUsuarioListadoMarcas.Click += new System.EventHandler(this.ViewUsuario);
            // 
            // btnUsuarioListadoProductos
            // 
            this.btnUsuarioListadoProductos.BorderRadius = 10;
            this.btnUsuarioListadoProductos.CheckedState.Parent = this.btnUsuarioListadoProductos;
            this.btnUsuarioListadoProductos.CustomImages.Parent = this.btnUsuarioListadoProductos;
            this.btnUsuarioListadoProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUsuarioListadoProductos.ForeColor = System.Drawing.Color.White;
            this.btnUsuarioListadoProductos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(84)))), ((int)(((byte)(108)))));
            this.btnUsuarioListadoProductos.HoverState.Parent = this.btnUsuarioListadoProductos;
            this.btnUsuarioListadoProductos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsuarioListadoProductos.ImageSize = new System.Drawing.Size(28, 28);
            this.btnUsuarioListadoProductos.Location = new System.Drawing.Point(6, 45);
            this.btnUsuarioListadoProductos.Name = "btnUsuarioListadoProductos";
            this.btnUsuarioListadoProductos.PressedColor = System.Drawing.Color.Teal;
            this.btnUsuarioListadoProductos.ShadowDecoration.Parent = this.btnUsuarioListadoProductos;
            this.btnUsuarioListadoProductos.Size = new System.Drawing.Size(191, 30);
            this.btnUsuarioListadoProductos.TabIndex = 6;
            this.btnUsuarioListadoProductos.Text = "Listado de productos";
            this.btnUsuarioListadoProductos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsuarioListadoProductos.TextOffset = new System.Drawing.Point(5, 0);
            this.btnUsuarioListadoProductos.Click += new System.EventHandler(this.ViewUsuario);
            // 
            // btnUsuarioHome
            // 
            this.btnUsuarioHome.BorderRadius = 10;
            this.btnUsuarioHome.CheckedState.Parent = this.btnUsuarioHome;
            this.btnUsuarioHome.CustomImages.Parent = this.btnUsuarioHome;
            this.btnUsuarioHome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUsuarioHome.ForeColor = System.Drawing.Color.White;
            this.btnUsuarioHome.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(84)))), ((int)(((byte)(108)))));
            this.btnUsuarioHome.HoverState.Parent = this.btnUsuarioHome;
            this.btnUsuarioHome.Image = global::proyectoDB_tienda_online.Properties.Resources.home;
            this.btnUsuarioHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsuarioHome.ImageSize = new System.Drawing.Size(28, 28);
            this.btnUsuarioHome.Location = new System.Drawing.Point(6, 6);
            this.btnUsuarioHome.Name = "btnUsuarioHome";
            this.btnUsuarioHome.PressedColor = System.Drawing.Color.Teal;
            this.btnUsuarioHome.ShadowDecoration.Parent = this.btnUsuarioHome;
            this.btnUsuarioHome.Size = new System.Drawing.Size(191, 30);
            this.btnUsuarioHome.TabIndex = 5;
            this.btnUsuarioHome.Text = "HOME";
            this.btnUsuarioHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsuarioHome.TextOffset = new System.Drawing.Point(5, 0);
            this.btnUsuarioHome.Click += new System.EventHandler(this.ViewUsuario);
            // 
            // pnlAdmi
            // 
            this.pnlAdmi.Controls.Add(this.btnAdminAjustes);
            this.pnlAdmi.Controls.Add(this.btnAdminReportes);
            this.pnlAdmi.Controls.Add(this.btnAdminProducto);
            this.pnlAdmi.Controls.Add(this.btnAdminMarca);
            this.pnlAdmi.Controls.Add(this.btnAdminCategoria);
            this.pnlAdmi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdmi.Location = new System.Drawing.Point(0, 86);
            this.pnlAdmi.Name = "pnlAdmi";
            this.pnlAdmi.Size = new System.Drawing.Size(200, 197);
            this.pnlAdmi.TabIndex = 5;
            // 
            // btnAdminAjustes
            // 
            this.btnAdminAjustes.BorderRadius = 10;
            this.btnAdminAjustes.CheckedState.Parent = this.btnAdminAjustes;
            this.btnAdminAjustes.CustomImages.Parent = this.btnAdminAjustes;
            this.btnAdminAjustes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdminAjustes.ForeColor = System.Drawing.Color.White;
            this.btnAdminAjustes.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(84)))), ((int)(((byte)(108)))));
            this.btnAdminAjustes.HoverState.Parent = this.btnAdminAjustes;
            this.btnAdminAjustes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminAjustes.ImageSize = new System.Drawing.Size(28, 28);
            this.btnAdminAjustes.Location = new System.Drawing.Point(3, 159);
            this.btnAdminAjustes.Name = "btnAdminAjustes";
            this.btnAdminAjustes.PressedColor = System.Drawing.Color.Teal;
            this.btnAdminAjustes.ShadowDecoration.Parent = this.btnAdminAjustes;
            this.btnAdminAjustes.Size = new System.Drawing.Size(191, 30);
            this.btnAdminAjustes.TabIndex = 4;
            this.btnAdminAjustes.Text = "AJUSTES";
            this.btnAdminAjustes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminAjustes.TextOffset = new System.Drawing.Point(5, 0);
            this.btnAdminAjustes.Visible = false;
            this.btnAdminAjustes.Click += new System.EventHandler(this.ViewAdmin);
            // 
            // btnAdminReportes
            // 
            this.btnAdminReportes.BorderRadius = 10;
            this.btnAdminReportes.CheckedState.Parent = this.btnAdminReportes;
            this.btnAdminReportes.CustomImages.Parent = this.btnAdminReportes;
            this.btnAdminReportes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdminReportes.ForeColor = System.Drawing.Color.White;
            this.btnAdminReportes.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(84)))), ((int)(((byte)(108)))));
            this.btnAdminReportes.HoverState.Parent = this.btnAdminReportes;
            this.btnAdminReportes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminReportes.ImageSize = new System.Drawing.Size(28, 28);
            this.btnAdminReportes.Location = new System.Drawing.Point(3, 123);
            this.btnAdminReportes.Name = "btnAdminReportes";
            this.btnAdminReportes.PressedColor = System.Drawing.Color.Teal;
            this.btnAdminReportes.ShadowDecoration.Parent = this.btnAdminReportes;
            this.btnAdminReportes.Size = new System.Drawing.Size(191, 30);
            this.btnAdminReportes.TabIndex = 3;
            this.btnAdminReportes.Text = "REPORTES";
            this.btnAdminReportes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminReportes.TextOffset = new System.Drawing.Point(5, 0);
            this.btnAdminReportes.Click += new System.EventHandler(this.ViewAdmin);
            // 
            // btnAdminProducto
            // 
            this.btnAdminProducto.BorderRadius = 10;
            this.btnAdminProducto.CheckedState.Parent = this.btnAdminProducto;
            this.btnAdminProducto.CustomImages.Parent = this.btnAdminProducto;
            this.btnAdminProducto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdminProducto.ForeColor = System.Drawing.Color.White;
            this.btnAdminProducto.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(84)))), ((int)(((byte)(108)))));
            this.btnAdminProducto.HoverState.Parent = this.btnAdminProducto;
            this.btnAdminProducto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminProducto.ImageSize = new System.Drawing.Size(28, 28);
            this.btnAdminProducto.Location = new System.Drawing.Point(3, 84);
            this.btnAdminProducto.Name = "btnAdminProducto";
            this.btnAdminProducto.PressedColor = System.Drawing.Color.Teal;
            this.btnAdminProducto.ShadowDecoration.Parent = this.btnAdminProducto;
            this.btnAdminProducto.Size = new System.Drawing.Size(191, 30);
            this.btnAdminProducto.TabIndex = 2;
            this.btnAdminProducto.Text = "PRODUCTOS";
            this.btnAdminProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminProducto.TextOffset = new System.Drawing.Point(5, 0);
            this.btnAdminProducto.Click += new System.EventHandler(this.ViewAdmin);
            // 
            // btnAdminMarca
            // 
            this.btnAdminMarca.BorderRadius = 10;
            this.btnAdminMarca.CheckedState.Parent = this.btnAdminMarca;
            this.btnAdminMarca.CustomImages.Parent = this.btnAdminMarca;
            this.btnAdminMarca.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdminMarca.ForeColor = System.Drawing.Color.White;
            this.btnAdminMarca.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(84)))), ((int)(((byte)(108)))));
            this.btnAdminMarca.HoverState.Parent = this.btnAdminMarca;
            this.btnAdminMarca.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminMarca.ImageSize = new System.Drawing.Size(28, 28);
            this.btnAdminMarca.Location = new System.Drawing.Point(3, 45);
            this.btnAdminMarca.Name = "btnAdminMarca";
            this.btnAdminMarca.PressedColor = System.Drawing.Color.Teal;
            this.btnAdminMarca.ShadowDecoration.Parent = this.btnAdminMarca;
            this.btnAdminMarca.Size = new System.Drawing.Size(191, 30);
            this.btnAdminMarca.TabIndex = 1;
            this.btnAdminMarca.Text = "MARCAS";
            this.btnAdminMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminMarca.TextOffset = new System.Drawing.Point(5, 0);
            this.btnAdminMarca.Click += new System.EventHandler(this.ViewAdmin);
            // 
            // btnAdminCategoria
            // 
            this.btnAdminCategoria.BorderRadius = 10;
            this.btnAdminCategoria.CheckedState.Parent = this.btnAdminCategoria;
            this.btnAdminCategoria.CustomImages.Parent = this.btnAdminCategoria;
            this.btnAdminCategoria.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdminCategoria.ForeColor = System.Drawing.Color.White;
            this.btnAdminCategoria.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(84)))), ((int)(((byte)(108)))));
            this.btnAdminCategoria.HoverState.Parent = this.btnAdminCategoria;
            this.btnAdminCategoria.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminCategoria.ImageSize = new System.Drawing.Size(28, 28);
            this.btnAdminCategoria.Location = new System.Drawing.Point(3, 6);
            this.btnAdminCategoria.Name = "btnAdminCategoria";
            this.btnAdminCategoria.PressedColor = System.Drawing.Color.Teal;
            this.btnAdminCategoria.ShadowDecoration.Parent = this.btnAdminCategoria;
            this.btnAdminCategoria.Size = new System.Drawing.Size(191, 33);
            this.btnAdminCategoria.TabIndex = 0;
            this.btnAdminCategoria.Text = "CATEGORIAS";
            this.btnAdminCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminCategoria.TextOffset = new System.Drawing.Point(5, 0);
            this.btnAdminCategoria.Click += new System.EventHandler(this.ViewAdmin);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bunifuLabel4);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 29);
            this.panel4.TabIndex = 4;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Hand;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel4.Location = new System.Drawing.Point(37, 6);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(93, 17);
            this.bunifuLabel4.TabIndex = 4;
            this.bunifuLabel4.Text = "Menu principal";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel4.Click += new System.EventHandler(this.OcultarMenu);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(60)))), ((int)(((byte)(180)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::proyectoDB_tienda_online.Properties.Resources.lista;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.OcultarMenu);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            this.panel3.Controls.Add(this.lblUsuario);
            this.panel3.Controls.Add(this.bunifuLabel2);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 57);
            this.panel3.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AllowParentOverrides = false;
            this.lblUsuario.AutoEllipsis = false;
            this.lblUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUsuario.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(62, 24);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUsuario.Size = new System.Drawing.Size(62, 17);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "userName";
            this.lblUsuario.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblUsuario.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(62, 5);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(51, 17);
            this.bunifuLabel2.TabIndex = 2;
            this.bunifuLabel2.Text = "Usuario:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::proyectoDB_tienda_online.Properties.Resources.user2;
            this.pictureBox3.Location = new System.Drawing.Point(9, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(200, 39);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(728, 533);
            this.pnlContenedor.TabIndex = 2;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 572);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(10, 20);
            this.Name = "FrmMenuPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlAdmi.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Panel pnlAdmi;
        private Guna.UI2.WinForms.Guna2Button btnAdminCategoria;
        private Guna.UI2.WinForms.Guna2Button btnUsuarioListadoProductos;
        private Guna.UI2.WinForms.Guna2Button btnUsuarioHome;
        private Guna.UI2.WinForms.Guna2Button btnAdminAjustes;
        private Guna.UI2.WinForms.Guna2Button btnAdminReportes;
        private Guna.UI2.WinForms.Guna2Button btnAdminProducto;
        private Guna.UI2.WinForms.Guna2Button btnAdminMarca;
        private Guna.UI2.WinForms.Guna2Button btnSalir;
        private Guna.UI2.WinForms.Guna2Button btnUsuarioListadoCategoria;
        private Guna.UI2.WinForms.Guna2Button btnUsuarioListadoMarcas;
        private System.Windows.Forms.Panel pnlContenedor;
        public Bunifu.UI.WinForms.BunifuLabel lblUsuario;
        private Guna.UI2.WinForms.Guna2Button btnCerrarSesion;
    }
}

