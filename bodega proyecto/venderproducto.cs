using System;
using System.Collections.Generic;
using System.Text;
using static bodega_proyecto.Producto;

namespace bodega_proyecto
{
    
    
        public class VenderProducto
        {
            public static void Ejecutar(Inventario inventario)
            {
                decimal total = 0;
                string continuar;

                List<DetalleVenta> detalleVenta = new List<DetalleVenta>();

                do
                {
                    Console.Write("Ingrese ID del producto: ");
                    int idVenta = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese cantidad: ");
                    int cantidad = int.Parse(Console.ReadLine());

                    Producto producto = inventario.ObtenerProducto(idVenta);

                    if (producto != null)
                    {
                        if (inventario.VenderProducto(idVenta, cantidad))
                        {
                            detalleVenta.Add(
                                new DetalleVenta(
                                    producto.Nombre,
                                    cantidad,
                                    producto.Precio
                                )
                            );

                            total += producto.Precio * cantidad;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Producto no encontrado.");
                    }

                    Console.Write("¿Desea agregar otro producto? (S/N): ");
                    continuar = Console.ReadLine().ToUpper();

                } while (continuar == "S");

                Console.WriteLine("\n===== RESUMEN DE LA VENTA =====");

                foreach (DetalleVenta item in detalleVenta)
                {
                    Console.WriteLine(
                        "Producto: " + item.Nombre +
                        " | Cantidad: " + item.Cantidad +
                        " | Precio: S/ " + item.Precio +
                        " | Subtotal: S/ " + item.Subtotal()
                    );
                }

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("TOTAL A PAGAR: S/ " + total);
                Console.WriteLine("-----------------------------------");
            Console.WriteLine("\nSeleccione el método de pago:");
            Console.WriteLine("1. Efectivo");
            Console.WriteLine("2. Tarjeta");
            Console.WriteLine("3. QR");

            Console.Write("Opción: ");
            string opcionPago = Console.ReadLine();

            switch (opcionPago)
            {
                case "1":

                    Console.Write("Ingrese con cuánto pagará: S/ ");
                    decimal pago = decimal.Parse(Console.ReadLine());

                    if (pago >= total)
                    {
                        decimal vuelto = pago - total;

                        Console.WriteLine("\n===== PAGO EN EFECTIVO =====");
                        Console.WriteLine("Total: S/ " + total);
                        Console.WriteLine("Pago: S/ " + pago);
                        Console.WriteLine("Vuelto: S/ " + vuelto);
                    }
                    else
                    {
                        Console.WriteLine("El monto ingresado es insuficiente.");
                    }

                    break;

                case "2":

                    decimal totalTarjeta = total + (total * 0.05m);

                    Console.WriteLine("\n===== PAGO CON TARJETA =====");
                    Console.WriteLine("Recargo (5%): S/ " + (total * 0.05m));
                    Console.WriteLine("Total a pagar: S/ " + totalTarjeta);

                    break;

                case "3":

                    Console.WriteLine("\n===== PAGO POR QR =====");
                    Console.WriteLine("Total a pagar: S/ " + total);

                    break;

                default:

                    Console.WriteLine("Método de pago inválido.");

                    break;
            }
        }


        }
    }

