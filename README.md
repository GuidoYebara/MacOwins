MacOwins es un proyecto de programacion III, hecho en c#. Tiene clases, metodos, propiedades, y el diagrama de clases en archivo cd. Tambien encontrara el diagrama en jpg.

Aclaración: El código está comentado y explica cada clase y método.
            El código de los métodos fue escrito en pseudocódigo.
            Se agregó algún que otro método adicional.
            La lista disponibles de prendas se agregó al escenario, pero no está comtemplado en el pseucódigo de las ventas. A cada venta solo se le debería poder agregar una                  prenda que exista en la lista de disponibles, y de ahí tomar la información de la misma. De lo contrario, se estaría creando una prenda nueva, con toda su info., cada              vez que cerramos una venta. Esto no fue escrito en pseudocódigo. 

----- 07/04/2021 -----
Aclaración 2: Una prenda no es una prenda individual; si no que sería un tipo de prenda. Ej: cod 3 - Jean marca Legacy - Estado: Nuevo. Una instancia no sería un solo Jean; es ese             tipo de Jean marca Legacy. En una venta podés tener 5 de esos mismos Jeans, y para eso sirve la clase linea factura, para poder contabilizarlos en la misma venta.

            Venta:

            Cod 3 - Jean marca Legacy. Cant: 5
            Cod 4 - Camisa Hugo Boss. Cant: 2
