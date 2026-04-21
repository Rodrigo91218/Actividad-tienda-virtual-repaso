using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_tienda_virtual_repaso
{
    class Program
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
                Console.WriteLine("3 - Cargar nueva venta");
                Console.WriteLine("4 - ");
                Console.WriteLine("5 - Mostrar lista de productos");
                Console.WriteLine("6 - ");
                Console.WriteLine("0 - Salir");

                opcion = MetodosGenericos.ValidarInt(0, 6);

                switch (opcion)
                {
                    case 1:
                        Cliente.AgregarCliente();
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
