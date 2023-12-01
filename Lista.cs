using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad3_recuperacion
{
    public class Lista
    {
       private Nodo _Principio;
       private Nodo _Final;

        public Lista() {
            _Principio = null;
            _Final = null;
        }

        public void IngresaDatos() {
            Autos autos= new Autos();
            Console.WriteLine("Registrar autos");
            Console.WriteLine("Ingrese La modelo");
            autos.marca = Console.ReadLine();
            Console.WriteLine("Ingrese La marca");
            autos.modelo = Console.ReadLine();
            Console.WriteLine("Ingrese La Año");
            autos.año = Convert.ToInt32(Console.ReadLine());

            Nodo nuevo=new Nodo(autos);
            if (_Principio == null)
                _Final = _Principio = nuevo;
            else
                _Final = _Final.Siguiente = nuevo;
        }
        public int Longitud() {
            int _Cont = 0;
            Nodo _actual= _Principio;
            while (_actual != null)
            {
                _Cont++;
                _actual= _actual.Siguiente;
            }
            return _Cont;
        }
        public void Imprimir()
        {

            Nodo _actual = _Principio;
            if (_Principio == null)
            {
                Console.WriteLine("La Lista esta vacio");
            }
            else
            {
                while (_actual != null)
                {
                    Console.WriteLine($"Marca : {_actual.Datos.marca}\nModelo: {_actual.Datos.modelo}\nAño   : {_actual.Datos.año} \n");
                    _actual = _actual.Siguiente;
                }
                if (_Principio == null)
                {
                    Console.WriteLine("esta vacio");
                }
            }
        }

        public void Buscar()
        {
            
            int _Cont = 0;
            Nodo _actual = _Principio;
            if (_Principio == null)
            {
                Console.WriteLine("La Lista esta vacio");
            }
            else
            {
                Console.WriteLine("Ingrese la marca para su busqueda ");
                string _Buscar = Console.ReadLine(); 
                while (_actual != null)
                {
                    _Cont++;
                   
                        if (_actual.Datos.marca == _Buscar)
                        {
                            Console.WriteLine($"esta en la pocicion {_Cont}\nMarca : {_actual.Datos.marca}\nModelo: {_actual.Datos.modelo}\nAño   : {_actual.Datos.año} \n ");
                        
                        }
                _actual = _actual.Siguiente;
                }
            
            }
        }
    }
}
