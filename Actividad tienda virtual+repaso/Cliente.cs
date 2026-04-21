using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_tienda_virtual_repaso
{
    public class Cliente
    {
        private static List<Cliente> clientes = new List<Cliente>();
        private string nombre;
        private string mail;

        public Cliente()
        {
            this.nombre = "";
            this.mail = "";
        }
        public Cliente(string nombre, string mail)
        {
            this.nombre = nombre;
            this.mail = mail;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Mail { get => mail; set => mail = value; }
        public static List<Cliente> Clientes { get => clientes; set => clientes = value; }


        public static Cliente AgregarCliente()
        {
            Cliente c = new Cliente();

            Console.WriteLine("\n************* Nuevo cliente *************");
            Console.WriteLine("Ingrese los siguientes datos");

            Console.Write("Nombre: ");
            c.Nombre = Console.ReadLine();

            Console.Write("E-mail: ");

            c.Guardar();

            Console.WriteLine("\n************* Cliente agregado correctamente *************");
            return c;
        }

        public void Guardar()
        {
            Cliente.clientes.Add(this);
        }

    }
}