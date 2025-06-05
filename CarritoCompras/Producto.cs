using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    public class Producto
    {
        int codigo;
        string nombre;
        double precio;
        int stock;
        Categoria categoria;

        public Producto(int codigo, string nombre, double precio, int stock, Categoria categoria)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
            this.categoria = categoria;
        }

    }
}
