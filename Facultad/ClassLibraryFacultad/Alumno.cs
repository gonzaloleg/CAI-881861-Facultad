using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFacultad
{
    class Alumno : Persona
    {
        private int _codigo;

        public int Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }
        public override string GetCredencial()
        {
            return "Codigo " + Codigo + " " + Apellido + " " + Nombre;
        }

        public override string ToString()
        {
            return GetCredencial();
        }

    }
}
