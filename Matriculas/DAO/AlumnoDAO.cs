using Matriculas.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.DAO
{
    internal class AlumnoDAO : Dao
    {
        private List<Alumno> listaAlumno = new List<Alumno>();

        private Alumno FinValue()
        {
            Console.WriteLine($"INGRESE EL EMAIL DEL ALUMNO : ");
            string email = Console.ReadLine();

            Alumno alumno = listaAlumno.Find(a => a.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
            return alumno;
        }

        public override void Create()
        {
            base.mensaje.mostrarTitulo("REGISTRO DE NUEVO ALUMNO");

            Console.WriteLine("ID : ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("NOMBRE : ");
            string nombre = Console.ReadLine();
            Console.WriteLine("EMAIL : ");
            string email = Console.ReadLine();
            Console.WriteLine("NOTA : ");
            int nota = int.Parse(Console.ReadLine());

            Alumno NuevoAlumno = new Alumno(id, nombre, email,nota);
            listaAlumno.Add(NuevoAlumno);
            base.mensaje.mostrarMensaje("ALUMNO REGISTRADO CON EXITO!!");

        }

        public override void Read()
        {
            base.mensaje.mostrarTitulo("RELACIÓN DE ALUMNOS");
            foreach (var alumno in listaAlumno)
            {
                Console.WriteLine(new string('*', 50));
                alumno.Mostrar();
            }
        }

        public override void Update()
        {
            base.mensaje.mostrarTitulo("ACTUALIZAR ALUMNO");
            Alumno alumno = this.FinValue();
            if (alumno != null)
            {
                Console.WriteLine("NUEVO NOMBRE : ");
                string nuevoNombre = Console.ReadLine();
                Console.WriteLine("NUEVO EMAIL : ");
                string nuevoEmail = Console.ReadLine();
                Console.WriteLine("NUEVA NOTA : ");
                int nuevaNota = int.Parse(Console.ReadLine());

                alumno.Nombre = nuevoNombre;
                alumno.Email = nuevoEmail;
                alumno.Nota = nuevaNota;

                this.mensaje.mostrarMensaje("ALUMNO ACTUALIZADO CON EXITO !!!");

            }
            else
            {
                this.mensaje.mostrarMensaje("ALUMNO NO ENCONTRADO ....");
            }

        }

        public override void Delete()
        {
            base.mensaje.mostrarTitulo("ELIMINAR ALUMNO");
            Alumno alumno = this.FinValue();
            if (alumno != null)
            {
               listaAlumno.Remove(alumno);
                this.mensaje.mostrarMensaje("ALUMNO ELIMINADO CON EXITO !!!");
            }
            else
            {
                this.mensaje.mostrarMensaje("ALUMNO NO ENCONTRADO ....");
            }

        }

    }
}
