using System;
using System.Collections.Generic;
using System.Text;

namespace bodega_proyecto
{
   
    
        public class EliminarProducto
        {
            public static void Ejecutar(Inventario inventario)
            {
                Console.Write("Ingrese el ID del producto a eliminar: ");
                int id = int.Parse(Console.ReadLine());

                inventario.EliminarProducto(id);
            }
        }
   }

