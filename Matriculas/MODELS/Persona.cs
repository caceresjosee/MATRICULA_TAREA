using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.MODELS
{
    internal class Persona
    {
        private int id;
        private string nombre;
        private string email;

        public Persona(int id, string nombre, string email)
        {
            this.id = id;
            this.Nombre = nombre;
            this.Email = email;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }

        public virtual void Mostrar()
        {
            Console.WriteLine($"ID: {this.id} ");
            Console.WriteLine($"NOMBRE : {this.Nombre}");
            Console.WriteLine($"EMAIL : {this.Email}");
        }
    }
}
