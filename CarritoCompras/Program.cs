using System;

namespace CarritoCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrito cart = new Carrito();
            Tienda tienda = new Tienda();

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
                        foreach (Categoria c in tienda.Categories)
                        {
                            c.VerCategorias();
                        }
                        break;

                    case "2":

                        foreach (Producto p in tienda.Productos)
                        {
                            p.VerProductos();
                        }

                        break;

                    case "3":

                        Console.WriteLine("Ingrese la categoría: ");
                        string category = Console.ReadLine();

                        Categoria filtro = tienda.Categories.Find(x => x.nombre == category);

                        if (filtro != null)
                        {
                            foreach (Producto p in tienda.Productos)
                            {
                                p.VerProductosPorFiltro(filtro);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Categoría inválida");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Ingrese el código del producto: ");
                        string ID = Console.ReadLine();
                        int cod = int.Parse(ID);
                        Console.WriteLine("Ingrese la cantidad a llevar: ");
                        string cant = Console.ReadLine();
                        int amount = int.Parse(cant);

                        Producto productoEncontrado = tienda.Productos.Find(x => x.codigo == cod);


                        if (productoEncontrado != null && amount <= productoEncontrado.stock && amount > 0 && productoEncontrado.stock > 0)
                        {
                            cart.Agregar(productoEncontrado, amount);
                        }
                        else
                        {
                            Console.WriteLine("Operación fallida: stock insuficiente o producto no encontrado.");
                        } 

                        break;

                        case "5":
                            Console.Write("Ingrese el código del producto a eliminar: ");
                            int codigo = int.Parse(Console.ReadLine());
                            carrito.EliminarItem(codigo);
                            break;
                    
                        case "6":
                            carrito.VerCarrito();
                            break;
                    
                        case "7":
                            double total = carrito.Total();
                            Console.WriteLine($"Total a pagar: ${total}");
                            break;
                    
                        case "8":
                            if (carrito.EstaVacio())
                            {
                                Console.WriteLine("No hay productos en el carrito.");
                                return;
                            }
                    
                            carrito.Total();
                            carrito.listaItems.Clear();
                            Console.WriteLine("¡Compra finalizada con éxito!");
                            break;
                    
                        case "0":
                            break;
                    
                        default:
                            Console.WriteLine("Opción no válida");
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
