using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CocoaBikiny.Utilidades;

using CapaEntidad;
using CapaNegocios;

namespace CocoaBikiny
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

            cbEstado.Items.Add(new OpcionCombo() {Valor = 1 , Texto = "Activo" }) ;
            cbEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cbEstado.DisplayMember = "Texto";
            cbEstado.ValueMember = "Valor";
            cbEstado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().Listar();

            foreach (Rol item in listaRol) {
                cbRol.Items.Add(new OpcionCombo() { Valor = item.IDrol, Texto = item.descripcion });
            }
            cbRol.DisplayMember = "Texto";
            cbRol.ValueMember = "Valor";
            cbRol.SelectedIndex = 0;


            foreach (DataGridViewColumn columna in dgvdata.Columns){

                if (columna.Visible == true && columna.Name != "BtnSeleccionar")
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            dgvdata.Rows.Add(new object[] {"",txtID.Text, txtNombreDocumento.Text,txNombreCompleto.Text, txtCorreoElectronico.Text, txtContraseña.Text,
               ((OpcionCombo)cbRol.SelectedItem).Valor.ToString(),
               ((OpcionCombo)cbRol.SelectedItem).Texto.ToString(),
               ((OpcionCombo)cbEstado.SelectedItem).Valor.ToString(),
               ((OpcionCombo)cbEstado.SelectedItem).Texto.ToString()
            });

            Limpiar();

        }
        private void Limpiar()
        {
            txtID.Text = "0";
            txtNombreDocumento.Text = "";
            txNombreCompleto.Text = "";
            txtCorreoElectronico.Text = "";
            txtContraseña.Text = "";
            txtConfirmarContra.Text = "";
            cbRol.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;

        }
    }
}
