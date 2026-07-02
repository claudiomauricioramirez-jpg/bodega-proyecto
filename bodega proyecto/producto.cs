using System;
using System.Collections.Generic;
using System.Text;

namespace bodega_proyecto
{
    
    
        public class Producto
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
            public int Stock { get; set; }

            public Producto(int id, string nombre, decimal precio, int stock)
            {
                Id = id;
                Nombre = nombre;
                Precio = precio;
                Stock = stock;
            }

            public void IngresarStock(int cantidad)
            {
                Stock += cantidad;
            }

            public bool VenderProducto(int cantidad)
            {
                if (cantidad <= Stock)
                {
                    Stock -= cantidad;
                    Console.WriteLine("Venta realizada correctamente");
                    return true;
                }
                else
                {
                    Console.WriteLine("No hay suficiente stock para la venta");
                    return false;
                }
            }
        }
    }

