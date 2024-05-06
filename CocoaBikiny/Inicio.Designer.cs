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
            this.menuusuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuventas = new FontAwesome.Sharp.IconMenuItem();
            this.menuproductos = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.menucodigodebarras = new FontAwesome.Sharp.IconMenuItem();
            this.menutop = new System.Windows.Forms.MenuStrip();
            this.titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
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
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
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
            this.menuusuarios.Size = new System.Drawing.Size(150, 50);
            this.menuusuarios.Text = "Usuarios";
            this.menuusuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuusuarios.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // menuventas
            // 
            this.menuventas.AutoSize = false;
            this.menuventas.BackColor = System.Drawing.Color.PaleVioletRed;
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
            this.menuventas.Click += new System.EventHandler(this.menuventas_Click);
            // 
            // menuproductos
            // 
            this.menuproductos.AutoSize = false;
            this.menuproductos.BackColor = System.Drawing.Color.PaleVioletRed;
            this.menuproductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem1,
            this.iconMenuItem2});
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
            this.menuproductos.Click += new System.EventHandler(this.iconMenuItem2_Click);
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
            this.menureportes.Click += new System.EventHandler(this.iconMenuItem3_Click);
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
            this.menutop.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menutop_ItemClicked);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titulo.Location = new System.Drawing.Point(28, 21);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(289, 32);
            this.titulo.TabIndex = 2;
            this.titulo.Text = "Sistema Cocoa Bikini";
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(805, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 57);
            this.label1.TabIndex = 3;
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.iconMenuItem1.Text = "Productos";
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.iconMenuItem2.Text = "Categorías";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
    }
}

