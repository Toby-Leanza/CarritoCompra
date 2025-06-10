using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    public class Tienda
    {
        public List<Producto> Productos { get; set; } = new List<Producto>();
        public List<Categoria> Categories { get; set; } = new List<Categoria>();
        
        public Tienda()
        {
            Categories.Add(new Categoria("Electrodomésticos", "Productos para una mayor comodidad hogareña"));
            Categories.Add(new Categoria("Frutas", "Frutas frescas de estación"));
            Categories.Add(new Categoria("Lácteos", "Leche, yogures y quesos"));
            Categories.Add(new Categoria("Panadería", "Pan, facturas y productos horneados"));
            Categories.Add(new Categoria("Bebidas", "Gaseosas, jugos, aguas"));
            Categories.Add(new Categoria("Limpieza", "Artículos de limpieza para el hogar"));
            Categories.Add(new Categoria("Carnes", "Carne vacuna, pollo, cerdo"));
            Categories.Add(new Categoria("Tecnología", "Celulares, notebooks y más"));
            
            Productos.Add(new Producto(1001, "Heladera", 900000.0, 5, Categories[0]));
            Productos.Add(new Producto(1002, "Microondas", 120000.0, 8, Categories[0]));
            Productos.Add(new Producto(1003, "Lavarropas", 350000.0, 3, Categories[0]));

            Productos.Add(new Producto(2001, "Manzana", 300.0, 50, Categories[1]));
            Productos.Add(new Producto(2002, "Banana", 250.0, 40, Categories[1]));
            Productos.Add(new Producto(2003, "Naranja", 280.0, 45, Categories[1]));

            Productos.Add(new Producto(3001, "Leche entera", 900.0, 30, Categories[2]));
            Productos.Add(new Producto(3002, "Yogur bebible", 350.0, 20, Categories[2]));
            Productos.Add(new Producto(3003, "Queso cremoso", 1200.0, 15, Categories[2]));

            Productos.Add(new Producto(4001, "Pan francés", 450.0, 25, Categories[3]));
            Productos.Add(new Producto(4002, "Facturas surtidas", 800.0, 10, Categories[3]));

            Productos.Add(new Producto(5001, "Gaseosa cola 2L", 900.0, 30, Categories[4]));
            Productos.Add(new Producto(5002, "Agua sin gas 1.5L", 600.0, 25, Categories[4]));
            Productos.Add(new Producto(5003, "Jugo de naranja 1L", 750.0, 20, Categories[4]));

            Productos.Add(new Producto(6001, "Lavandina 1L", 450.0, 20, Categories[5]));
            Productos.Add(new Producto(6002, "Jabón en polvo", 1600.0, 10, Categories[5]));
            Productos.Add(new Producto(6003, "Detergente", 500.0, 18, Categories[5]));

            Productos.Add(new Producto(7001, "Carne picada", 2500.0, 12, Categories[6]));
            Productos.Add(new Producto(7002, "Pechuga de pollo", 2800.0, 10, Categories[6]));

            Productos.Add(new Producto(8001, "Celular Android", 250000.0, 6, Categories[7]));
            Productos.Add(new Producto(8002, "Notebook 14\"", 550000.0, 4, Categories[7]));
            Productos.Add(new Producto(8003, "Procesadores AMD", 150000.0, 7, Categories[7]));

        }

        


    }
   
}
