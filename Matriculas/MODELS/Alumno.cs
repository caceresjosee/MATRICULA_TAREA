using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.MODELS
{
    internal class Alumno:Persona
    {
        private int nota;

        public Alumno(int id,string nombre,string email, int nota):base(id, nombre,email)
        {
            this.nota = nota;
        }

        public int Nota { get => nota; set => nota = value; }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"NOTA : {this.nota}");
        }

    }
}
