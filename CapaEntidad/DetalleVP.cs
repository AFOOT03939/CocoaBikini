using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleVP
    {
        public int detalleVP {  get; set; }
        public Producto? oProducto { get; set; }
        public Sucursal? oSucursal { get; set; }
        public decimal? totalventa {  get; set; }
        public int cantidad { get; set; }
        public string? fecha {  get; set; }

    }
}
