using System;
using System.Collections.Generic;
using System.Text;

namespace bodega_proyecto
{
    public class DetalleVenta
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public DetalleVenta(string nombre, int cantidad, decimal precio)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
        }

        public decimal Subtotal()
        {
            return Precio * Cantidad;
        }
    }
}
