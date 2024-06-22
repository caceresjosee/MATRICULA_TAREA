using Matriculas.UTILS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.UI
{
    internal abstract class UI
    {
        const int ANCHO = 50;
        protected Mensaje mensaje = new Mensaje(ANCHO);


        public abstract void MostrarMenu();
     
     
    }
}
