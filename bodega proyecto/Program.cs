using bodega_proyecto;
class Program
{
    static void Main(string[] args)
    {
        Inventario inventario = InicializarInventario.Ejecutar();

        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n===== MENÚ =====");
            Console.WriteLine("1. Listar Productos");
            Console.WriteLine("2. Agregar Producto");
            Console.WriteLine("3. Vender Producto");
            Console.WriteLine("4. Buscar Producto");
            Console.WriteLine("5. Eliminar Producto");
            Console.WriteLine("6. Reabastecer Stock");
            Console.WriteLine("7. Salir");

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();


            switch (opcion)
            {
                case "1":
                    ListarProductos.Ejecutar(inventario);
                    break;

                case "2":
                    AgregarProducto.Ejecutar(inventario);
                    break;

                case "3":
                    VenderProducto.Ejecutar(inventario);
                    break;

                case "4":
                    BuscarProducto.Ejecutar(inventario);
                    break;

                case "5":
                    EliminarProducto.Ejecutar(inventario);
                    break;

                case "6":
                    ReabastecerStock.Ejecutar(inventario);
                    break;

                case "7":
                    salir = true;
                    Console.WriteLine("Programa finalizado");
                    break;
            }
        }
    }
}