using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_tienda_virtual_repaso
{
    internal class Producto
    {
        private static List<Producto> productos = new List<Producto>();
        private string nombre;
        private string descripcion;
        private double precioVenta;
        private int cantInventario;

        public Producto()
        {
            this.nombre = "";
            this.descripcion = "";
            this.precioVenta = 0;
            this.cantInventario = 0;
        }

        public Producto(string nombre, string descripcion,double precioVenta, int cantInventario)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precioVenta = precioVenta;
            this.cantInventario = cantInventario;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public static List<Producto> Productos { get => productos; set => productos = value; }
    }
}
