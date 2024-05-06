using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public int IDVenta {  get; set; }
        public Usuarios? oUsuarios {  get; set; }
        public string? Fecha {  get; set; }
        public Producto? oProducto { get; set; }
        public Sucursal? oSucursal {  get; set; }
        public decimal Total {  get; set; }
        public decimal Cambio {  get; set; }
        public List<DetalleVP>? odetalleVP { get; set; }
        public List<DetalleVS>? odetalleVS { get; set; }
    }
}
