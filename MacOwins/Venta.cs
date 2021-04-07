using System;
using System.Collections.Generic;
using System.Text;

namespace MacOwins
{
    public enum metodo : int
    {
        efectivo = 1,
        tarjeta = 2
    }

    /// <summary>
    /// La clase representa una venta, con su codigo, fecha, el metodo de pago
    /// empleado, la cantidad de cuottas y el preciototal que se calcula con 
    /// el metodo CalcularPrecio.
    /// Cada venta tiene asociada una lista de lineas factura.
    /// </summary>
    public class Venta
    {

        public float codigoVta { get; set; }
        public DateTime fecha { get; set; }
        public int metodopago { get; set; }
        public int cantidaddecuotas { get; set; }
        public float preciototal { get; set; }
        public float coeficientefijo { get; set; }
        public List<LineaFactura> lineasfactura { get; set; }

        public Venta()
        {
            lineasfactura = new List<LineaFactura>();
            ///Completar datos de la venta como cantidaddecuotas, metodo y coef. fijo.
            AgregarPrendasAVenta();

            CalcularPrecio();
        }

        /// <summary>
        /// Agrega los productos que son parte de una venta mediante el agregado de lineas de factura
        /// </summary>
        public void AgregarPrendasAVenta()
        {
            /* PseudoCodigo

             pedir al usuario ingreso de prendas
             mientras usuario ingrese un codigo, y no valor 'continuar'
                 usuario ingresa codigo de prenda
                 usuario completa todos los campos de una prenda
                 usuario ingresa la cantidad vendida para esa prenda en esta venta
                 se crea una linea de factura, y se le asocia la prenda creada, con la cantidad
                 se agrega la linea creada a la lista lineasfactura

             terminar

            ACLARACION: sería prudente que el codigo se validara en la lista de prendas disponibles, pero
                    no está contemplado en el enunciado.

                */
        }

        /// <summary>
        /// Calcula el precio total con todas las consideraciones del enunciado, 
        /// y lo guarda en la propiedad preciototal. El método es llamado por el 
        /// constructor de la clase, ya que es mandatorio que toda venta tenga su precio total.
        /// Pero también puede ser llamado en cualquier momento para actualizar el precio.
        /// </summary>
        public void CalcularPrecio() 
        {

            /* PseudoCodigo
            
            por cada linea de factura en lineas factura
                traer precio base de la prenda asociada a la linea
                traer estado de la prenda
             
                si el estado es nueva:
                        precio=preciobase
                si el estado es promocion:
                        predir al usuario ingresar valor de descuento
                        precio=preciobase-valoringresado
                si el estado es liquidacio:
                        precio=preciobase*0.5

                traer la cantidad de la linea factura
                preciototal+=precio*cantidad
            terminar
            
            pedir al usuario el metodo de pago
            guardar metodo en propiedad metodopago

            si el metodo es tarjeta:
                preciototal=preciototal*(cantidadcuotas*coeficientefijo+preciototal*0.01)
            
            */
        }


    }
}
