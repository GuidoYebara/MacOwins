using System;
using System.Collections.Generic;
using System.Text;

namespace MacOwins
{
    /// <summary>
    /// Cada venta tiene multiples lineas de factura, y cada linea de factura es 
    /// un producto, y la cantidad del mismo.
    /// </summary>
    public class LineaFactura
    {
        public Prenda prenda { get; set; }
        public int cantidad { get; set; }
    }
}
