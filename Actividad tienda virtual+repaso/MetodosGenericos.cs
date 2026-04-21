using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_tienda_virtual_repaso
{
    public class MetodosGenericos()
	{

        public static int ValidarInt(int min = int.MinValue, int max = int.MaxValue)
        {
            int num;

            while (!int.TryParse(Console.ReadLine(), out num) || (num < min || num > max))
            {
                Console.WriteLine("Valor incorrecto, solo números enteros" + (min != int.MinValue ? " entre " + min + " y " + max : "") + "\nIntente nuevamente:");
            }
            return num;
        }
}
