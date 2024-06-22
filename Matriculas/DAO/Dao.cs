using Matriculas.MODELS;
using Matriculas.UTILS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.DAO
{
    internal abstract class Dao
    {
        protected Mensaje mensaje = new Mensaje(50);

        public abstract void Create();
        public abstract void Read();
        public abstract void Update();
        public abstract void Delete();
    
    }
}
