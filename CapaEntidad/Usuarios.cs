using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuarios
    {
        public int IDUsuario {  get; set; }
        public string? Nombre {  get; set; }
        public string? correo {  get; set; }
        public string? password {  get; set; }
        public Rol? orol { get; set; }
        public string? fecha { get; set; }
    }
}
