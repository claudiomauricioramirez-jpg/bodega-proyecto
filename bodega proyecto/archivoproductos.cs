using System;
using System.Collections.Generic;
using System.IO;

namespace bodega_proyecto
{
    public class ArchivoProductos
    {
        private const string ruta = "productos.txt";

        // Guarda todos los productos en el archivo
        public static void Guardar(List<Producto> productos)
        {
            StreamWriter writer = new StreamWriter(ruta);

            foreach (Producto producto in productos)
            {
                writer.WriteLine(
                    producto.Id + "," +
                    producto.Nombre + "," +
                    producto.Precio + "," +
                    producto.Stock);
            }

            writer.Close();
        }

        // Carga los productos desde el archivo
        public static List<Producto> Cargar()
        {
            List<Producto> productos = new List<Producto>();

            if (!File.Exists(ruta))
            {
                File.Create(ruta).Close();
                return productos;
            }

            StreamReader reader = new StreamReader(ruta);

            while (!reader.EndOfStream)
            {
                string linea = reader.ReadLine();

                string[] datos = linea.Split(',');

                Producto producto = new Producto(
                    int.Parse(datos[0]),
                    datos[1],
                    decimal.Parse(datos[2]),
                    int.Parse(datos[3]));

                productos.Add(producto);
            }

            reader.Close();

            return productos;
        }
    }
}