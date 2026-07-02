using System;
using System.Collections.Generic;
using System.Text;

namespace bodega_proyecto
{
    
        public class ReabastecerStock
        {
            public static void Ejecutar(Inventario inventario)
            {
                Console.Write("Ingrese el ID del producto: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad a agregar: ");
                int cantidad = int.Parse(Console.ReadLine());

                inventario.ReabastecerStock(id, cantidad);
            }
        }
    }
