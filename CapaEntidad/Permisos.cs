using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Permisos
    {
        public int IDPermiso {  get; set; }
        public Rol? oRol { get; set; }
        public string? nombre {  get; set; }
        public string? fecha {  get; set; }
    }
}
