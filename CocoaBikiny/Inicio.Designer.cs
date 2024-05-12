namespace CocoaBikiny
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuventas = new FontAwesome.Sharp.IconMenuItem();
            this.submenuRegistrarVenta = new FontAwesome.Sharp.IconMenuItem();
            this.submenuDetalleVenta = new FontAwesome.Sharp.IconMenuItem();
            this.menuproductos = new FontAwesome.Sharp.IconMenuItem();
            this.submenuProductos = new FontAwesome.Sharp.IconMenuItem();
            this.submenuCategorias = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.menucodigodebarras = new FontAwesome.Sharp.IconMenuItem();
            this.menuusuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menutop = new System.Windows.Forms.MenuStrip();
            this.titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.lblusuario = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Gainsboro;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuventas,
            this.menuproductos,
            this.menureportes,
            this.menucodigodebarras,
            this.menuusuarios});
            this.menu.Location = new System.Drawing.Point(0, 72);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(917, 74);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuventas
            // 
            this.menuventas.AutoSize = false;
            this.menuventas.BackColor = System.Drawing.Color.PaleVioletRed;
            this.menuventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuRegistrarVenta,
            this.submenuDetalleVenta});
            this.menuventas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuventas.ForeColor = System.Drawing.Color.Snow;
            this.menuventas.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.menuventas.IconColor = System.Drawing.Color.Snow;
            this.menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuventas.IconSize = 36;
            this.menuventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuventas.ImageTransparentColor = System.Drawing.Color.White;
            this.menuventas.Margin = new System.Windows.Forms.Padding(10);
            this.menuventas.Name = "menuventas";
            this.menuventas.Size = new System.Drawing.Size(150, 50);
            this.menuventas.Text = "Ventas";
            this.menuventas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // submenuRegistrarVenta
            // 
            this.submenuRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuRegistrarVenta.IconColor = System.Drawing.Color.Black;
            this.submenuRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuRegistrarVenta.Name = "submenuRegistrarVenta";
            this.submenuRegistrarVenta.Size = new System.Drawing.Size(207, 22);
            this.submenuRegistrarVenta.Text = "Registrar Venta";
            this.submenuRegistrarVenta.Click += new System.EventHandler(this.submenuRegistrarVenta_Click);
            // 
            // submenuDetalleVenta
            // 
            this.submenuDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuDetalleVenta.IconColor = System.Drawing.Color.Black;
            this.submenuDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuDetalleVenta.Name = "submenuDetalleVenta";
            this.submenuDetalleVenta.Size = new System.Drawing.Size(207, 22);
            this.submenuDetalleVenta.Text = "Detalle de Venta";
            this.submenuDetalleVenta.Click += new System.EventHandler(this.submenuDetalleVenta_Click);
            // 
            // menuproductos
            // 
            this.menuproductos.AutoSize = false;
            this.menuproductos.BackColor = System.Drawing.Color.PaleVioletRed;
            this.menuproductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuProductos,
            this.submenuCategorias});
            this.menuproductos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuproductos.ForeColor = System.Drawing.Color.Snow;
            this.menuproductos.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.menuproductos.IconColor = System.Drawing.Color.Snow;
            this.menuproductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuproductos.IconSize = 36;
            this.menuproductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproductos.ImageTransparentColor = System.Drawing.Color.White;
            this.menuproductos.Margin = new System.Windows.Forms.Padding(10);
            this.menuproductos.Name = "menuproductos";
            this.menuproductos.Size = new System.Drawing.Size(150, 50);
            this.menuproductos.Text = "Productos";
            this.menuproductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // submenuProductos
            // 
            this.submenuProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuProductos.IconColor = System.Drawing.Color.Black;
            this.submenuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuProductos.Name = "submenuProductos";
            this.submenuProductos.Size = new System.Drawing.Size(164, 22);
            this.submenuProductos.Text = "Productos";
            this.submenuProductos.Click += new System.EventHandler(this.submenuProductos_Click);
            // 
            // submenuCategorias
            // 
            this.submenuCategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuCategorias.IconColor = System.Drawing.Color.Black;
            this.submenuCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuCategorias.Name = "submenuCategorias";
            this.submenuCategorias.Size = new System.Drawing.Size(164, 22);
            this.submenuCategorias.Text = "Categorías";
            this.submenuCategorias.Click += new System.EventHandler(this.submenuCategorias_Click);
            // 
            // menureportes
            // 
            this.menureportes.AutoSize = false;
            this.menureportes.BackColor = System.Drawing.Color.PaleVioletRed;
            this.menureportes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menureportes.ForeColor = System.Drawing.Color.Snow;
            this.menureportes.IconChar = FontAwesome.Sharp.IconChar.File;
            this.menureportes.IconColor = System.Drawing.Color.Snow;
            this.menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureportes.IconSize = 36;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.ImageTransparentColor = System.Drawing.Color.White;
            this.menureportes.Margin = new System.Windows.Forms.Padding(10);
            this.menureportes.Name = "menureportes";
            this.menureportes.Size = new System.Drawing.Size(150, 50);
            this.menureportes.Text = "Reportes";
            this.menureportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menureportes.Click += new System.EventHandler(this.menureportes_Click);
            // 
            // menucodigodebarras
            // 
            this.menucodigodebarras.AutoSize = false;
            this.menucodigodebarras.BackColor = System.Drawing.Color.PaleVioletRed;
            this.menucodigodebarras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menucodigodebarras.ForeColor = System.Drawing.Color.Snow;
            this.menucodigodebarras.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.menucodigodebarras.IconColor = System.Drawing.Color.Snow;
            this.menucodigodebarras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucodigodebarras.IconSize = 36;
            this.menucodigodebarras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucodigodebarras.ImageTransparentColor = System.Drawing.Color.White;
            this.menucodigodebarras.Margin = new System.Windows.Forms.Padding(10);
            this.menucodigodebarras.Name = "menucodigodebarras";
            this.menucodigodebarras.Size = new System.Drawing.Size(200, 50);
            this.menucodigodebarras.Text = "Código de barras";
            this.menucodigodebarras.Click += new System.EventHandler(this.menucodigodebarras_Click);
            // 
            // menuusuarios
            // 
            this.menuusuarios.AutoSize = false;
            this.menuusuarios.BackColor = System.Drawing.Color.PaleVioletRed;
            this.menuusuarios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuusuarios.ForeColor = System.Drawing.Color.Snow;
            this.menuusuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            this.menuusuarios.IconColor = System.Drawing.Color.Snow;
            this.menuusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuarios.IconSize = 36;
            this.menuusuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuarios.ImageTransparentColor = System.Drawing.Color.White;
            this.menuusuarios.Margin = new System.Windows.Forms.Padding(10);
            this.menuusuarios.Name = "menuusuarios";
            this.menuusuarios.Size = new System.Drawing.Size(122, 50);
            this.menuusuarios.Text = "Usuarios";
            this.menuusuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuusuarios.Click += new System.EventHandler(this.menuusuarios_Click);
            // 
            // menutop
            // 
            this.menutop.AutoSize = false;
            this.menutop.BackColor = System.Drawing.Color.PaleVioletRed;
            this.menutop.Location = new System.Drawing.Point(0, 0);
            this.menutop.Name = "menutop";
            this.menutop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutop.Size = new System.Drawing.Size(917, 72);
            this.menutop.TabIndex = 1;
            this.menutop.Text = "menuStrip2";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titulo.Location = new System.Drawing.Point(297, 20);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(297, 32);
            this.titulo.TabIndex = 2;
            this.titulo.Text = "Sistema Cocoa Bikiny";
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 57);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(706, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 146);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(917, 344);
            this.Contenedor.TabIndex = 5;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lblusuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblusuario.Location = new System.Drawing.Point(787, 31);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(88, 18);
            this.lblusuario.TabIndex = 6;
            this.lblusuario.Text = "lblUsuario";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 490);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menutop;
        private System.Windows.Forms.Label titulo;
        private FontAwesome.Sharp.IconMenuItem menucodigodebarras;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem menuproductos;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuusuarios;
        private FontAwesome.Sharp.IconMenuItem submenuProductos;
        private FontAwesome.Sharp.IconMenuItem submenuCategorias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Contenedor;
        private FontAwesome.Sharp.IconMenuItem submenuRegistrarVenta;
        private FontAwesome.Sharp.IconMenuItem submenuDetalleVenta;
        private System.Windows.Forms.Label lblusuario;
    }
}

