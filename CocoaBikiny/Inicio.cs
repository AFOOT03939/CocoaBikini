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

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menucodigodebarras_Click(object sender, EventArgs e)
        {

        }

        private void menutop_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void abrirform(IconMenuItem menu, Form formuario)
        {

        }

        private void menuventas_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

            
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {

            if (MenuActivo != null)
            {
                
                MenuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.HotPink;
            MenuActivo = menu;

        }
    }
}
