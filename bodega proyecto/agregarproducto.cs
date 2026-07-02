using System;
using System.Collections.Generic;
using System.Text;
using static bodega_proyecto.Producto;

namespace bodega_proyecto
{
    public class AgregarProducto
    {
        public static void Ejecutar(Inventario inventario)
        {
            Console.Write("Ingrese ID del producto: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese stock: ");
            int stock = int.Parse(Console.ReadLine());

            Producto producto = new Producto(id, nombre, precio, stock);

            inventario.AgregarProducto(producto);
        }
    }
}
