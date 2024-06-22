using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.UTILS
{
    internal class Mensaje
    {
        private int ancho;

        public Mensaje(int ancho)
        {
            this.ancho = ancho;
        }
        public void mostrarTitulo(string titulo)
        {
            Console.WriteLine(new string('=', this.ancho));
            Console.WriteLine(new string(' ', 15) + titulo);
            Console.WriteLine(new string('=', this.ancho));
        }

        public void mostrarMensaje(string mensaje)
        {
            Console.Clear();
            Console.WriteLine(new string('*', this.ancho));
            Console.WriteLine(new string(' ', 15) + mensaje);
            Console.WriteLine(new string('*', this.ancho));
            System.Threading.Thread.Sleep(1000);
        }
    }
}
