using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_y_Colas_Ejercicios_Unidad_4
{
    public class Pila
    {
        //Los campos los hacemos private
        private int _cima;

        //Creamos un arreglo de tipo entero
        private int[] listaPila;

        //Le pedimos al usuario las cantidades necesarias
        private int longitudPila = 5;

        //Creamos un contructor de esta clase
        public Pila()
        {
            //Se inicializa que cima sera igual a menos 1 
            _cima = -1;
            //En este codigo la lista esta vacia
            //A la pila le hace falta la fila
            listaPila = new int[longitudPila];
        }
        //Hacemos una instancia

        //Verificar si la lista esta vacia
        public bool PilaVacia()
        {
            //Son dos metodos en los que verificamos si la lista esta vacia o no
            if(_cima == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
           // return _cima == -1 ? true : false;
        }
        //Metodo para verificar si la lista esta llena
        public bool PilaLlena()
        {
            //Son dos metodos en los que verificamos si la lista esta llena o no

            if (_cima == longitudPila-1)
            {
                return true;
            }
            else
            {
                return false;
            }
          //  return _cima == longitudPila-1 ? true : false;
        }
        //Metodo de saber el tamaño de la lista 
        public int LongitudPilas()
        {
            return longitudPila;
        }
        //Que nos devuelva la cantidad de elemetos que tiene la pila
        public int CantidadElementosPilas()
        {
            return _cima + 1;
        }
        //Obtener el valor de la cima
        public int ValorCima()
        {
            return listaPila[_cima];
        }
        //Insertar un nuevo elemento en la fila
        public bool InsertarValorFila(int valor)
        {
            if (PilaLlena())
            {
                return false;
            }
            else
            {
                _cima++;
                listaPila[_cima] = valor;
                return true;
            }

        }
        //Extraer un elemento
        public int ExtraerElemento()
        {
            if (PilaVacia())
            {
                Console.WriteLine("La pila esta vacia");
                return _cima;
            }
            else
            {
                //Crear una variable  
                int aux = listaPila[_cima];
                _cima--;
                return aux;
            }
        }

    }
}











