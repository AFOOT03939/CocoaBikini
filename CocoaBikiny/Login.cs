using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaEntidad;

namespace CocoaBikiny
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Usuario> listaUsuarios = new UsuarioCN().Listar(); // Obtener la lista de usuarios.
            Usuario oUsuario = listaUsuarios.FirstOrDefault(u => u.password == contra.Text && u.Nombre == User.Text); // Buscar el usuario específico en la lista.


            if (oUsuario != null)
            {
                Inicio form = new Inicio(oUsuario);
                form.Show();
                this.Hide();
                form.FormClosing += frmClosing;
            }
            else
            {
                MessageBox.Show("no se encontró el usuario", "Mensaje", MessageBoxButtons.OK) ;
            }

        }

        private void frmClosing(object sender, FormClosingEventArgs e)
        {
            contra.Text = "";
            User.Text = "";
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
