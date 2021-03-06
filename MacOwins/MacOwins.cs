using System;
using System.Collections.Generic;
using System.Text;

namespace MacOwins
{
    /// <summary>
    /// Esta clase guarda las ventas en memoria, en un listado, y 
    /// sirve para correr metodos generales del negocio como
    /// el calculo de ganancias para un dia determinado
    /// </summary>
    public class MacOwins
    {
        /// <summary>
        /// Agregado al escenario. La tienda deberia tener un listado de prendas disponibles
        /// Las ventas tienen que sacar los codigos de prendas y la info. de esta lista.
        /// </summary>
        public List<Prenda> lista_prendasdisponibles { get; set; }

        public List<Venta> lista_ventas { get; set; }

        /// <summary>
        /// el metodo utiliza el listado de ventas guardado para sumar los precios
        /// totales de las mismas y filtrarlo por la fecha determinada
        /// </summary>
        /// <param name="fechaingresada"></param>
        /// <returns></returns>
        public float CalcularGananciasPorFecha(DateTime fechaingresada)
        {
            float ganancias=0;
            
            /*pseudocodigo
            
            por cada venta en la lista ventas:
                si fechaingresada == fechadelaventa
                    ganancias+=preciototal de la venta
            terminar

             */
            return ganancias;
        }

        /// <summary>
        /// Agregado al escenario. El vendedor puede ver la info. de cualquier prenda disponible.
        /// </summary>
        /// <param name="codigoprendaingresado"></param>
        public void MostrarPrenda(int codigoprendaingresado)
        {
            /*pseudocodigo

                por cada prenda en la lista prendas:
                    si codigoprendaingresado == codigo de la prenda
                        mostrar en pantalla el codigo, el precio base, y el tipo
                terminar

              */

        }

    }
}
