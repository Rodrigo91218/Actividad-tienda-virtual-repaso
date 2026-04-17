using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_tienda_virtual_repaso
{
    internal class Cliente
    {
        private static List<Cliente> clientes = new List<Cliente>();
        private string nombre;
        private string mail;
        private string dirEnvio;

        public Cliente()
        {
            this.nombre = "";
            this.dirEnvio = "";
            this.email = "";
        }
        public Cliente(string nombre, string mail, string dirEnvio)
        {
            this.nombre = nombre;
            this.mail = mail;
            this.dirEnvio = dirEnvio;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string DirEnvio { get => dirEnvio; set => dirEnvio = value; }
        public string Email { get => email; set => email = value; }
        public static List<Cliente> Clientes { get => clientes; set => clientes = value; }


    }
}