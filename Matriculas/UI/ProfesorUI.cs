using Matriculas.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.UI
{
    internal class ProfesorUI :UI
    {
        private ProfesorDAO dao = new ProfesorDAO();

        public ProfesorUI() 
        {
            dao = new ProfesorDAO();
        }

        public override void MostrarMenu()
        {
            int opcion = 0;
            while (opcion != 5)
            {
                Console.Clear();
                base.mensaje.mostrarTitulo("MANTENIMIENTO DE PROFESORES");
                Console.WriteLine(@"
                    [1] REGISTRAR PROFESOR
                    [2] MOSTRAR PROFESORES
                    [3] ACTUALIZAR PROFESOR
                    [4] ELIMINAR PROFESOR
                    [5] SALIR
                ");
                base.mensaje.mostrarTitulo("INGRESE UNA OPCIÓN DEL MENU: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        dao.Create();
                        break;
                    case 2:
                        dao.Read();
                        Console.WriteLine("PRESIONE ENTER PARA CONTINUAR...");
                        Console.ReadKey();
                        break;
                    case 3:
                        dao.Update();
                        break;
                    case 4:
                        dao.Delete();
                        break;
                    case 5:
                        Console.WriteLine("SALIENDO DEL SISTEMA ... ");

                        break;
                    default:
                        base.mensaje.mostrarMensaje("OPCIÓN INVALIDA!!!");
                        break;
                }
            }
        }



    }
}
