using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFacultad
{
    class Alumno : Persona
    {
        private int _codigo;

        public string Credencial
        {
            set { this._nombre = value; this._apellido = value; this._codigo = int.Parse(value); }
         
        }
        public override string GetCredencial()
        {
            
        }
    }
}
