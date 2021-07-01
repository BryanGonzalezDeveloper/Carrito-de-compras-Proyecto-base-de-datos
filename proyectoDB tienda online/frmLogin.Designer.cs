
namespace proyectoDB_tienda_online
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegistrarse = new System.Windows.Forms.LinkLabel();
            this.cboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtcontraseña = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtCorreo = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(57, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(144, 23);
            this.bunifuLabel1.TabIndex = 2;
            this.bunifuLabel1.Text = "INICIO DE SESION";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(310, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.toolTip1.SetToolTip(this.button1, "Salir de la aplicacion");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCerrarLogin);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BorderRadius = 10;
            this.btnIniciarSesion.CheckedState.Parent = this.btnIniciarSesion;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.CustomImages.Parent = this.btnIniciarSesion;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(84)))), ((int)(((byte)(108)))));
            this.btnIniciarSesion.HoverState.Parent = this.btnIniciarSesion;
            this.btnIniciarSesion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnIniciarSesion.ImageSize = new System.Drawing.Size(28, 28);
            this.btnIniciarSesion.Location = new System.Drawing.Point(108, 205);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.PressedColor = System.Drawing.Color.Teal;
            this.btnIniciarSesion.ShadowDecoration.Parent = this.btnIniciarSesion;
            this.btnIniciarSesion.Size = new System.Drawing.Size(111, 33);
            this.btnIniciarSesion.TabIndex = 9;
            this.btnIniciarSesion.Text = "Iniciar sesión";
            this.btnIniciarSesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnIniciarSesion.TextOffset = new System.Drawing.Point(5, 0);
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.AutoSize = true;
            this.btnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.LinkColor = System.Drawing.Color.White;
            this.btnRegistrarse.Location = new System.Drawing.Point(120, 256);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(97, 17);
            this.btnRegistrarse.TabIndex = 10;
            this.btnRegistrarse.TabStop = true;
            this.btnRegistrarse.Text = "Registrarse.";
            this.btnRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnRegistrarse_LinkClicked);
            // 
            // cboTipoUsuario
            // 
            this.cboTipoUsuario.FormattingEnabled = true;
            this.cboTipoUsuario.Items.AddRange(new object[] {
            "Cliente",
            "Administrador"});
            this.cboTipoUsuario.Location = new System.Drawing.Point(140, 71);
            this.cboTipoUsuario.Name = "cboTipoUsuario";
            this.cboTipoUsuario.Size = new System.Drawing.Size(136, 21);
            this.cboTipoUsuario.TabIndex = 11;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(11, 71);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(123, 17);
            this.bunifuLabel2.TabIndex = 12;
            this.bunifuLabel2.Text = "Iniciar sesion como:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.AcceptsReturn = false;
            this.txtcontraseña.AcceptsTab = false;
            this.txtcontraseña.AnimationSpeed = 200;
            this.txtcontraseña.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtcontraseña.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtcontraseña.BackColor = System.Drawing.Color.Transparent;
            this.txtcontraseña.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtcontraseña.BackgroundImage")));
            this.txtcontraseña.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtcontraseña.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtcontraseña.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtcontraseña.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtcontraseña.BorderRadius = 1;
            this.txtcontraseña.BorderThickness = 1;
            this.txtcontraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcontraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcontraseña.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtcontraseña.DefaultText = "";
            this.txtcontraseña.FillColor = System.Drawing.Color.White;
            this.txtcontraseña.HideSelection = true;
            this.txtcontraseña.IconLeft = null;
            this.txtcontraseña.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcontraseña.IconPadding = 10;
            this.txtcontraseña.IconRight = null;
            this.txtcontraseña.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcontraseña.Lines = new string[0];
            this.txtcontraseña.Location = new System.Drawing.Point(56, 174);
            this.txtcontraseña.MaxLength = 32767;
            this.txtcontraseña.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtcontraseña.Modified = false;
            this.txtcontraseña.Multiline = false;
            this.txtcontraseña.Name = "txtcontraseña";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtcontraseña.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtcontraseña.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtcontraseña.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtcontraseña.OnIdleState = stateProperties4;
            this.txtcontraseña.Padding = new System.Windows.Forms.Padding(3);
            this.txtcontraseña.PasswordChar = '\0';
            this.txtcontraseña.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtcontraseña.PlaceholderText = "Ingrese su contraseña";
            this.txtcontraseña.ReadOnly = false;
            this.txtcontraseña.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcontraseña.SelectedText = "";
            this.txtcontraseña.SelectionLength = 0;
            this.txtcontraseña.SelectionStart = 0;
            this.txtcontraseña.ShortcutsEnabled = true;
            this.txtcontraseña.Size = new System.Drawing.Size(220, 25);
            this.txtcontraseña.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtcontraseña.TabIndex = 8;
            this.txtcontraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcontraseña.TextMarginBottom = 0;
            this.txtcontraseña.TextMarginLeft = 3;
            this.txtcontraseña.TextMarginTop = 0;
            this.txtcontraseña.TextPlaceholder = "Ingrese su contraseña";
            this.txtcontraseña.UseSystemPasswordChar = false;
            this.txtcontraseña.WordWrap = true;
            this.txtcontraseña.TextChanged += new System.EventHandler(this.txtcontraseña_TextChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.AcceptsReturn = false;
            this.txtCorreo.AcceptsTab = false;
            this.txtCorreo.AnimationSpeed = 200;
            this.txtCorreo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCorreo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCorreo.BackColor = System.Drawing.Color.Transparent;
            this.txtCorreo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCorreo.BackgroundImage")));
            this.txtCorreo.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtCorreo.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCorreo.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtCorreo.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtCorreo.BorderRadius = 1;
            this.txtCorreo.BorderThickness = 1;
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtCorreo.DefaultText = "";
            this.txtCorreo.FillColor = System.Drawing.Color.White;
            this.txtCorreo.HideSelection = true;
            this.txtCorreo.IconLeft = null;
            this.txtCorreo.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.IconPadding = 10;
            this.txtCorreo.IconRight = null;
            this.txtCorreo.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.Lines = new string[0];
            this.txtCorreo.Location = new System.Drawing.Point(56, 120);
            this.txtCorreo.MaxLength = 32767;
            this.txtCorreo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCorreo.Modified = false;
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCorreo.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCorreo.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCorreo.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCorreo.OnIdleState = stateProperties8;
            this.txtCorreo.Padding = new System.Windows.Forms.Padding(3);
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtCorreo.PlaceholderText = "Ingrese su correo electronico";
            this.txtCorreo.ReadOnly = false;
            this.txtCorreo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.ShortcutsEnabled = true;
            this.txtCorreo.Size = new System.Drawing.Size(220, 25);
            this.txtCorreo.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtCorreo.TabIndex = 7;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCorreo.TextMarginBottom = 0;
            this.txtCorreo.TextMarginLeft = 3;
            this.txtCorreo.TextMarginTop = 0;
            this.txtCorreo.TextPlaceholder = "Ingrese su correo electronico";
            this.txtCorreo.UseSystemPasswordChar = false;
            this.txtCorreo.WordWrap = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::proyectoDB_tienda_online.Properties.Resources.password;
            this.pictureBox3.Location = new System.Drawing.Point(11, 167);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::proyectoDB_tienda_online.Properties.Resources.email;
            this.pictureBox2.Location = new System.Drawing.Point(11, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyectoDB_tienda_online.Properties.Resources.grupo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(339, 282);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.cboTipoUsuario);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.UI.WinForms.BunifuTextBox txtCorreo;
        private Guna.UI2.WinForms.Guna2Button btnIniciarSesion;
        private System.Windows.Forms.LinkLabel btnRegistrarse;
        private System.Windows.Forms.ComboBox cboTipoUsuario;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.ToolTip toolTip1;
        public Bunifu.UI.WinForms.BunifuTextBox txtcontraseña;
    }
}