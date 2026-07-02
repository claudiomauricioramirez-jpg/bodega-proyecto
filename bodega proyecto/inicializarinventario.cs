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

            inventario.CargarProductos(ArchivoProductos.Cargar());

            return inventario;
            }
        }
    }

