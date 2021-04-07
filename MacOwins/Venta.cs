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
    /// Cada venta tiene asociada una lista de prendas que se vendieron en la misma.
    /// A modo de simplificar el escenario, los codigos pueden repetirse, lo que significaria que esa prenda se vendio
    /// mas de una vez. 
    /// </summary>
    public class Venta
    {

        public float codigoVta { get; set; }
        public DateTime fecha { get; set; }
        public int metodopago { get; set; }
        public int cantidaddecuotas { get; set; }
        public float preciototal { get; set; }
        public List<Prenda> lista_prendasenvta { get; set; }

        public Venta()
        {
            lista_prendasenvta = new List<Prenda>();

            ///En estas lineas, los datos fecha, codigoVta, metodopago, cantidadcuotas
            ///seria completado.

            AgregarPrendasAVenta();

            CalcularPrecio();
        }

        public void AgregarPrendasAVenta()
        {
            /* PseudoCodigo

             pedir al usuario ingreso de prendas
             mientras usuario ingrese un codigo, y no valor 'continuar'
                 usuario ingresa codigo de prenda
                 ACLARACION: el codigo deberia validarse en la lista de prendas disponibles
                y copiar las instancias a esta lista. A modo de simplifar el modelo,
                no se representará dicho escenario.
                 guardar codigo en lista 'prendas'
             terminar*/

        }

        /// <summary>
        /// Calcula el precio total con todas las consideraciones del enunciado, 
        /// y lo guarda en la propiedad preciototal. El método es llamado por el 
        /// constructor de la clase, ya que es mandatorio que toda venta tenga su precio total.
        /// Pero también puede ser llamado en cualquier momento para actualizar el precio.
        /// </summary>
        public void CalcularPrecio() {

            /*
            
            por cada codigo de prenda en lista 'prendas':
                traer precio base de la prenda
                traer estado de la prenda
                si el estado es nueva:
                        precio=preciobase
                si el estado es promocion:
                        predir al usuario ingresar valor de descuento
                        precio=preciobase-valoringresado
                si el estado es liquidacio:
                        precio=preciobase*0.5
                preciototal+=precio
               
            terminar
            
            pedir al usuario el metodo de pago
            guardar metodo en propiedad metodopago

            si el metodo es tarjeta:
                preciototal=preciototal*(cantidadcuotas*coeficientefijo+preciototal*0.01)
            
            */
        }


    }
}
