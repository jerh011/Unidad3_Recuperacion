using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Unidad3_recuperacion
{
    public  class Nodo
    {
        private Autos _Dato;
        private Nodo _Siguiente;

        public Nodo(Autos datos) 
        { 
            _Dato= datos;
            _Siguiente = null;        
        }

        public Autos Datos { 
            get { return _Dato; }
            set { _Dato = value; }
        }
        public Nodo Siguiente
        {
            get { return _Siguiente; }
            set { _Siguiente = value; }
        }
    }
}
