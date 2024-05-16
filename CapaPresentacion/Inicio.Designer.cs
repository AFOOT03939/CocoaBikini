namespace CapaPresentacion
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
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.menuusuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menumantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.submenucategoria = new FontAwesome.Sharp.IconMenuItem();
            this.submenuproducto = new FontAwesome.Sharp.IconMenuItem();
            this.menuventas = new FontAwesome.Sharp.IconMenuItem();
            this.submenuregistrarventa = new FontAwesome.Sharp.IconMenuItem();
            this.submenuverdetalleventa = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.submenureporteventas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSucursales = new FontAwesome.Sharp.IconMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.añadirProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1214, 75);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menuStrip2";
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.LavenderBlush;
            this.contenedor.Controls.Add(this.label4);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(205, 75);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1009, 581);
            this.contenedor.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(-1, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(5, 600);
            this.label4.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(921, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lblusuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.White;
            this.lblusuario.Location = new System.Drawing.Point(1013, 32);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(21, 22);
            this.lblusuario.TabIndex = 5;
            this.lblusuario.Text = "X";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.LogoCanal;
            this.pictureBox1.Location = new System.Drawing.Point(1086, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titulo.Location = new System.Drawing.Point(436, 22);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(297, 32);
            this.titulo.TabIndex = 12;
            this.titulo.Text = "Sistema Cocoa Bikiny";
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 57);
            this.label1.TabIndex = 13;
            // 
            // MenuAcercaDe
            // 
            this.MenuAcercaDe.AutoSize = false;
            this.MenuAcercaDe.BackColor = System.Drawing.Color.LavenderBlush;
            this.MenuAcercaDe.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuAcercaDe.ForeColor = System.Drawing.Color.Black;
            this.MenuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.MenuAcercaDe.IconColor = System.Drawing.Color.Black;
            this.MenuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuAcercaDe.IconSize = 35;
            this.MenuAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuAcercaDe.Margin = new System.Windows.Forms.Padding(10, 55, 10, 15);
            this.MenuAcercaDe.Name = "MenuAcercaDe";
            this.MenuAcercaDe.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MenuAcercaDe.Size = new System.Drawing.Size(175, 50);
            this.MenuAcercaDe.Text = "Acerca de";
            this.MenuAcercaDe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MenuAcercaDe.Click += new System.EventHandler(this.MenuAcercaDe_Click);
            // 
            // menuusuarios
            // 
            this.menuusuarios.AutoSize = false;
            this.menuusuarios.BackColor = System.Drawing.Color.LavenderBlush;
            this.menuusuarios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuusuarios.ForeColor = System.Drawing.Color.Black;
            this.menuusuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            this.menuusuarios.IconColor = System.Drawing.Color.Black;
            this.menuusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuarios.IconSize = 40;
            this.menuusuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuarios.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.menuusuarios.Name = "menuusuarios";
            this.menuusuarios.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.menuusuarios.Size = new System.Drawing.Size(175, 50);
            this.menuusuarios.Text = "Usuarios";
            this.menuusuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuusuarios.Click += new System.EventHandler(this.menuusuarios_Click);
            // 
            // menumantenedor
            // 
            this.menumantenedor.AutoSize = false;
            this.menumantenedor.BackColor = System.Drawing.Color.LavenderBlush;
            this.menumantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenucategoria,
            this.submenuproducto,
            this.añadirProductosToolStripMenuItem});
            this.menumantenedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menumantenedor.ForeColor = System.Drawing.Color.Black;
            this.menumantenedor.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.menumantenedor.IconColor = System.Drawing.Color.Black;
            this.menumantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menumantenedor.IconSize = 40;
            this.menumantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menumantenedor.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.menumantenedor.Name = "menumantenedor";
            this.menumantenedor.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.menumantenedor.Size = new System.Drawing.Size(175, 50);
            this.menumantenedor.Text = "Productos";
            this.menumantenedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // submenucategoria
            // 
            this.submenucategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenucategoria.IconColor = System.Drawing.Color.Black;
            this.submenucategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenucategoria.Name = "submenucategoria";
            this.submenucategoria.Size = new System.Drawing.Size(240, 26);
            this.submenucategoria.Text = "Categoria";
            this.submenucategoria.Click += new System.EventHandler(this.submenucategoria_Click);
            // 
            // submenuproducto
            // 
            this.submenuproducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuproducto.IconColor = System.Drawing.Color.Black;
            this.submenuproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuproducto.Name = "submenuproducto";
            this.submenuproducto.Size = new System.Drawing.Size(240, 26);
            this.submenuproducto.Text = "Producto";
            this.submenuproducto.Click += new System.EventHandler(this.submenuproducto_Click);
            // 
            // menuventas
            // 
            this.menuventas.AutoSize = false;
            this.menuventas.BackColor = System.Drawing.Color.LavenderBlush;
            this.menuventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuregistrarventa,
            this.submenuverdetalleventa});
            this.menuventas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuventas.ForeColor = System.Drawing.Color.Black;
            this.menuventas.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.menuventas.IconColor = System.Drawing.Color.Black;
            this.menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuventas.IconSize = 40;
            this.menuventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuventas.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.menuventas.Name = "menuventas";
            this.menuventas.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.menuventas.Size = new System.Drawing.Size(175, 50);
            this.menuventas.Text = "Ventas";
            this.menuventas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // submenuregistrarventa
            // 
            this.submenuregistrarventa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuregistrarventa.IconColor = System.Drawing.Color.Black;
            this.submenuregistrarventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuregistrarventa.Name = "submenuregistrarventa";
            this.submenuregistrarventa.Size = new System.Drawing.Size(181, 26);
            this.submenuregistrarventa.Text = "Registrar";
            this.submenuregistrarventa.Click += new System.EventHandler(this.submenuregistrarventa_Click);
            // 
            // submenuverdetalleventa
            // 
            this.submenuverdetalleventa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuverdetalleventa.IconColor = System.Drawing.Color.Black;
            this.submenuverdetalleventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuverdetalleventa.Name = "submenuverdetalleventa";
            this.submenuverdetalleventa.Size = new System.Drawing.Size(181, 26);
            this.submenuverdetalleventa.Text = "Ver Detalle";
            this.submenuverdetalleventa.Click += new System.EventHandler(this.submenuverdetalleventa_Click);
            // 
            // menureportes
            // 
            this.menureportes.AutoSize = false;
            this.menureportes.BackColor = System.Drawing.Color.LavenderBlush;
            this.menureportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenureporteventas});
            this.menureportes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menureportes.ForeColor = System.Drawing.Color.Black;
            this.menureportes.IconChar = FontAwesome.Sharp.IconChar.File;
            this.menureportes.IconColor = System.Drawing.Color.Black;
            this.menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureportes.IconSize = 40;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.menureportes.Name = "menureportes";
            this.menureportes.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.menureportes.Size = new System.Drawing.Size(175, 50);
            this.menureportes.Text = "Reportes";
            this.menureportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // submenureporteventas
            // 
            this.submenureporteventas.Name = "submenureporteventas";
            this.submenureporteventas.Size = new System.Drawing.Size(222, 26);
            this.submenureporteventas.Text = "Reporte Ventas";
            this.submenureporteventas.Click += new System.EventHandler(this.submenureporteventas_Click);
            // 
            // menuSucursales
            // 
            this.menuSucursales.AutoSize = false;
            this.menuSucursales.BackColor = System.Drawing.Color.LavenderBlush;
            this.menuSucursales.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSucursales.ForeColor = System.Drawing.Color.Black;
            this.menuSucursales.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.menuSucursales.IconColor = System.Drawing.Color.Black;
            this.menuSucursales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuSucursales.IconSize = 35;
            this.menuSucursales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuSucursales.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.menuSucursales.Name = "menuSucursales";
            this.menuSucursales.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.menuSucursales.Size = new System.Drawing.Size(175, 50);
            this.menuSucursales.Text = "Sucursales";
            this.menuSucursales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuSucursales.Click += new System.EventHandler(this.menuSucursales_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.PaleVioletRed;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.GripMargin = new System.Windows.Forms.Padding(-1);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAcercaDe,
            this.menuusuarios,
            this.menumantenedor,
            this.menuventas,
            this.menureportes,
            this.menuSucursales});
            this.menu.Location = new System.Drawing.Point(0, 75);
            this.menu.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.menu.Size = new System.Drawing.Size(205, 581);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(-3, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1231, 5);
            this.label3.TabIndex = 14;
            // 
            // añadirProductosToolStripMenuItem
            // 
            this.añadirProductosToolStripMenuItem.Name = "añadirProductosToolStripMenuItem";
            this.añadirProductosToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.añadirProductosToolStripMenuItem.Text = "Añadir Productos";
            this.añadirProductosToolStripMenuItem.Click += new System.EventHandler(this.añadirProductosToolStripMenuItem_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 656);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem MenuAcercaDe;
        private FontAwesome.Sharp.IconMenuItem menuusuarios;
        private FontAwesome.Sharp.IconMenuItem menumantenedor;
        private FontAwesome.Sharp.IconMenuItem submenucategoria;
        private FontAwesome.Sharp.IconMenuItem submenuproducto;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarventa;
        private FontAwesome.Sharp.IconMenuItem submenuverdetalleventa;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private System.Windows.Forms.ToolStripMenuItem submenureporteventas;
        private FontAwesome.Sharp.IconMenuItem menuSucursales;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem añadirProductosToolStripMenuItem;
    }
}

