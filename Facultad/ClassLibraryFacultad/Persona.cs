using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFacultad
{
    abstract class Persona
    {
        internal string _apellido;
        internal string _nombre;
        internal DateTime _fechaNac;


        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        // public int Edad
        // {
        //    get { return this._fechaNac; }
        //    set { this._fechaNac = int.Parse(value); }
        //}


        public string GetNombreCompleto()
        {
            return Nombre + " " + Apellido;
        }

        public abstract string GetCredencial();

    }
}
