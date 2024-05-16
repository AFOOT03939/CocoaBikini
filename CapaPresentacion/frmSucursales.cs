using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmSucursales : Form
    {
        public frmSucursales()
        {
            InitializeComponent();
        }

 
        private void LLBL1_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start("https://www.google.com.mx/maps/place/Cocoa+Bikiny+-+Sucursal+Rio+Nilo/@20.6393871,-103.2772633,17z/data=!3m1!4b1!4m6!3m5!1s0x8428b3c0e259a98f:0xe1926cdec9cd2785!8m2!3d20.6393821!4d-103.274683!16s%2Fg%2F11v3q19vq7?entry=ttu");
        }

        private void LLBL2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com.mx/maps/place/Cocoa+Bikiny+-+Sucursal+Zapopan/@20.6729401,-103.4267819,17z/data=!3m1!4b1!4m6!3m5!1s0x8428aff74f0fff19:0xe477413b84a461ca!8m2!3d20.6729351!4d-103.4242016!16s%2Fg%2F11y3tmlcx0?entry=ttu");
        }

        private void LLBL3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com.mx/maps/place/Cocoa+Bikiny+-+Sucursal+Ocotlán/@20.3508153,-102.7762542,17z/data=!3m1!4b1!4m14!1m7!3m6!1s0x8428cc9f4a2294a7:0x5b042975ba085667!2sCocoa+Bikiny+Matriz!8m2!3d20.618001!4d-103.0763707!16s%2Fg%2F11bw44g6z2!3m5!1s0x842ed92413f9ddfb:0x5203a248fa08055d!8m2!3d20.3508103!4d-102.7736739!16s%2Fg%2F11qbv4zg18?entry=ttu");
        }

        private void LLBL4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com.mx/maps/place/Cocoa+Bikiny+Matriz/@20.618006,-103.078951,17z/data=!3m1!4b1!4m6!3m5!1s0x8428cc9f4a2294a7:0x5b042975ba085667!8m2!3d20.618001!4d-103.0763707!16s%2Fg%2F11bw44g6z2?entry=ttu");
        }
    }
}
