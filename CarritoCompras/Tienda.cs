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
        public List<Categoria> Categorias { get; set; } = new List<Categoria>();
        public Tienda()
        {
            Productos.Add(new Producto(123456, "Heladera", 900000.0, 5, Categorias[0]));


            Categorias.Add(new Categoria("Electrodomésticos", "Productos para una mayor comodidad hogareña"));
        }
    }
   
}
