using System;

namespace bodega_proyecto
{
    public class AgregarProducto
    {
        public static void Ejecutar(Inventario inventario)
        {
            int id;

            Console.Write("Ingrese ID del producto: ");

            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Error: debe ingresar un número entero.");

                Console.Write("Ingrese nuevamente el ID: ");
            }

            if (inventario.ExisteProducto(id))
            {
                Console.WriteLine("Error: ya existe un producto con ese ID.");
                return;
            }

            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();

            decimal precio;

            Console.Write("Ingrese precio: ");

            while (!decimal.TryParse(Console.ReadLine(), out precio) || precio <= 0)
            {
                Console.WriteLine("Error: ingrese un precio válido mayor que 0.");
                Console.Write("Ingrese nuevamente el precio: ");
            }

            int stock;

            Console.Write("Ingrese stock: ");

            while (!int.TryParse(Console.ReadLine(), out stock) || stock <= 0)
            {
                Console.WriteLine("Error: debe ingresar un número entero.");

                Console.Write("Ingrese nuevamente el stock: ");
            }

            Producto producto = new Producto(
                id,
                nombre,
                precio,
                stock
            );

            inventario.AgregarProducto(producto);
        }
    }
}