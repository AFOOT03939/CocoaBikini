using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

using CapaEntidad;
using System.Runtime.Remoting.Channels;

namespace CocoaBikiny
{
    public partial class Inicio : Form
    {

        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Inicio(Usuario objusuario)
        {
            usuarioActual = objusuario;

            InitializeComponent();
        }

        private void menuventas_Click(object sender, EventArgs e)  /*MENU VENTAS */
        {

        }

        private void submenuRegistrarVenta_Click(object sender, EventArgs e) /* SUBMENU REGISTRAR VENTA*/
        {
            AbrirFormulario(menuventas, new frmVentas());
        }
        private void submenuDetalleVenta_Click(object sender, EventArgs e) /* SUBMENU DETALLE DE VENTA*/
        {
            AbrirFormulario(menuventas, new frmDetalleVentas());

        }
        private void submenuProductos_Click(object sender, EventArgs e)/* SUBMENU PRODUCTOS */
        {
            AbrirFormulario(menuproductos, new frmProducto());
        }
       
        private void submenuCategorias_Click(object sender, EventArgs e)/* SUBMENU CATEGORIAS */
        {
            AbrirFormulario(menuproductos, new frmCategoria());
        }
        private void menureportes_Click(object sender, EventArgs e) /* MENU REPORTES */
        {
            AbrirFormulario((IconMenuItem)sender, new frmReportes());
        }

        private void menucodigodebarras_Click(object sender, EventArgs e) /* MENU CODIGOS DE BARRAS */
        {
            AbrirFormulario((IconMenuItem)sender, new frmCodigodebarras());
        }
        
        private void menuusuarios_Click(object sender, EventArgs e)/* MENU USUARIOS */
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }



        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {

            if (MenuActivo != null)
            {
                
                MenuActivo.BackColor = Color.PaleVioletRed; /* HAY QUE ESCOGER AQUI COLORES, CUANDO SE CAMBIA DE MENU, EL MENU ANTERIOR SE PINTA DEL COLOR QUE SE PONGA AQUI*/
            }

            menu.BackColor = Color.Black; /* Este es el color del que se pinta el menu actual al que se le da click*/
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.Coral;

            Contenedor.Controls.Add(formulario);
            formulario.Show();

        }
    }
}
