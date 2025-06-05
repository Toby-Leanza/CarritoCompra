using System;

namespace CarritoCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrito cart = new Carrito();

            string opcion;

            do
            {

                Console.WriteLine("===== Bienvenidos al 39-Market =====");
                Console.WriteLine("1. Categorías disponibles");
                Console.WriteLine("2. Productos disponibles");
                Console.WriteLine("3. Ver productos por categoría");
                Console.WriteLine("4. Agregar un producto al carrito");
                Console.WriteLine("5. Eliminar producto del carrito");
                Console.WriteLine("6. Ver carrito");
                Console.WriteLine("7. Ver importe");
                Console.WriteLine("8. Finalizar compra");
                Console.WriteLine("0. Salir del sistema");
                Console.WriteLine("==========================");
                Console.Write("Seleccione una opción: ");
                opcion = Console.ReadLine();


                switch (opcion)
                {
                    case "1":
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "5":
                        break;

                    case "6":
                        break;

                    case "7":
                        break;

                    case "8":
                        break;

                    case "0":
                        break;

                    default:
                        break;

                }

                if (opcion != "0")
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear(); // Limpia la pantalla para mejor visualización
                }

            } while (opcion != "0");

            Console.WriteLine("¡Gracias por visitar 39-Market!");

        }
    }
}
