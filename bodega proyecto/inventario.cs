using System;
using System.Collections.Generic;
using System.Text;


namespace bodega_proyecto
{
    public class Inventario
    {
        private List<Producto> productos = new List<Producto>();

        // Agregar producto
        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
            Console.WriteLine("Producto agregado correctamente");
        }

        // Listar productos
        public void ListarProductos()
        {
            Console.WriteLine("\n===== LISTA DE PRODUCTOS =====");

            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos registrados.");
                return;
            }

            foreach (Producto producto in productos)
            {
                Console.WriteLine(
                    "ID: " + producto.Id +
                    " | Nombre: " + producto.Nombre +
                    " | Precio: S/ " + producto.Precio +
                    " | Stock: " + producto.Stock
                );
            }
        }

        // Vender producto
        public bool VenderProducto(int idProducto, int cantidad)
        {
            foreach (Producto producto in productos)
            {
                if (producto.Id == idProducto)
                {
                    return producto.VenderProducto(cantidad);
                }
            }

            Console.WriteLine("Producto no encontrado.");
            return false;
        }

        // Buscar producto
        public void BuscarProducto(int id)
        {
            foreach (Producto producto in productos)
            {
                if (producto.Id == id)
                {
                    Console.WriteLine("\n===== PRODUCTO ENCONTRADO =====");
                    Console.WriteLine(
                        "ID: " + producto.Id +
                        " | Nombre: " + producto.Nombre +
                        " | Precio: S/ " + producto.Precio +
                        " | Stock: " + producto.Stock
                    );
                    return;
                }
            }

            Console.WriteLine("Producto no encontrado.");
        }

        // Eliminar producto
        public void EliminarProducto(int id)
        {
            foreach (Producto producto in productos)
            {
                if (producto.Id == id)
                {
                    productos.Remove(producto);
                    Console.WriteLine("Producto eliminado correctamente.");
                    return;
                }
            }

            Console.WriteLine("Producto no encontrado.");
        }

        // Reabastecer stock
        public void ReabastecerStock(int id, int cantidad)
        {
            foreach (Producto producto in productos)
            {
                if (producto.Id == id)
                {
                    producto.IngresarStock(cantidad);
                    Console.WriteLine("Stock actualizado correctamente.");
                    return;
                }
            }

            Console.WriteLine("Producto no encontrado.");
        }

        // Obtener producto por ID
        public Producto ObtenerProducto(int id)
        {
            foreach (Producto producto in productos)
            {
                if (producto.Id == id)
                {
                    return producto;
                }
            }


            return null;
        }


        public List<Producto> ObtenerProductos()
        {
            return productos;
        }
    }
}

