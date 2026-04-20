using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_tienda_virtual_repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion; 

            do
            {
                Console.Clear(); 

                Console.WriteLine("Ingrese el número de la opción y luego enter:");
                Console.WriteLine("1 - Agregar un nuevo cliente");
                Console.WriteLine("2 - Agregar un nuevo producto");
                Console.WriteLine("3 - Agregar una nueva venta");
                Console.WriteLine("4 - Buscar clientes");
                Console.WriteLine("5 - Buscar productos");
                Console.WriteLine("6 - Buscar ventas");
                Console.WriteLine("0 - Salir");

                opcion = MetodosGenericos.ValidarInt(0, 6);

                switch (opcion)
                {
                    case 1:
                        
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        
                        break;
                    case 6:
                        
                        break;

                }
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey(); 

            } while (opcion != 0);
            Console.WriteLine("¡Hasta luego!");

            Console.ReadKey();

        }



    }
}
