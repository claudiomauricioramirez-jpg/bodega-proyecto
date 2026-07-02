using System;
using System.Collections.Generic;
using System.Text;

namespace bodega_proyecto
    {
        public class BuscarProducto
        {
            public static void Ejecutar(Inventario inventario)
            {
                Console.Write("Ingrese el ID del producto a buscar: ");
                int id = int.Parse(Console.ReadLine());

                inventario.BuscarProducto(id);
            }
        }
    }

