using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class UsuarioCN
    {
        private UsuarioCD objcd = new UsuarioCD();
        public List<Usuario> Listar()
        {
            return objcd.Listar();
        }
    }
}
