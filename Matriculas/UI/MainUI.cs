using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.UI
{
    internal class MainUI:UI
    {
        public override void MostrarMenu()
        {
            int opcion = 0;
            while (opcion != 5)
            {
                Console.Clear();
                this.mensaje.mostrarTitulo("SISTEMA DE MATRICULAS");
                Console.WriteLine(@"
                [1] ADMINISTRACION DE PROFESORES
                [2] ADMINISTRACION DE ALUMNOS
                [3] PROCESO DE MATRICULAS
                [4] REPORTES
                [5] SALIR
                ");
                this.mensaje.mostrarTitulo("INGRESE UNA OPCIÓN DEL MENU: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        ProfesorUI ui = new ProfesorUI();
                        ui.MostrarMenu();
                        break;
                    case 2:
                        AlumnoUI uiA=new AlumnoUI();
                        uiA.MostrarMenu();
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:
                        Console.WriteLine("SALIENDO DEL SISTEMA ... ");

                        break;
                    default:
                        this.mensaje.mostrarMensaje("OPCIÓN INVALIDA!!!");
                        break;
                }
            }
        }


    }
}
