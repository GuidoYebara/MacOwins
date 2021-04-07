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
        }

        public void AgregarPrendasAVenta()
        {
            /* PseudoCodigo

             pedir al usuario ingreso de prendas
             mientras usuario ingrese un codigo, y no valor 'continuar'
                 usuario ingresa codigo de prenda
                 guardar codigo en lista 'prendas'
             terminar*/

        }
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
