using System;
using System.Collections.Generic;
using System.Text;
using static bodega_proyecto.Producto;

namespace bodega_proyecto
{
  
        public class InicializarInventario
        {
            public static Inventario Ejecutar()
            {
                Inventario inventario = new Inventario();

                inventario.AgregarProducto(new Producto(1, "Arroz", 10.5m, 100));
                inventario.AgregarProducto(new Producto(2, "Azúcar", 5.0m, 50));

                return inventario;
            }
        }
    }

