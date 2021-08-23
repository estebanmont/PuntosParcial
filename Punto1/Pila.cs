using System;
using System.Collections.Generic;
using System.Text;

namespace Punto1
{
    class Pila
    {
        private Nodo ultimo;
        private int totalNodos;

        public Pila apilar(int info)
        {
            Nodo nuevo = new Nodo(info, ultimo);
            ultimo = nuevo;
            totalNodos++;
            return this;
        }



        public bool vacia()
        {
            return ultimo == null;
        }

        public int getTotalNodos()
        {
            return totalNodos;
        }

        public int getUltimo()
        { // peek
            return ultimo.getInfo();
        }

        public void Visualizar()
        {
            if (vacia())
            {
                Console.WriteLine("No hay elementos apilados");
            }
            else
            {
                Nodo nodo = ultimo;

                while (nodo != null)
                {
                    Console.WriteLine(nodo.getInfo() + " ");
                    nodo = nodo.getSiguiente();
                }
                Console.WriteLine();
            }
        }

        public int esPrimo2(int numero, int cont)
        {
            while (cont >= 1)
            {
                if (cont == 1)
                {
                    return 1;
                }


                else if (numero % cont == 0)

                {
                    return 0;
                }

                cont--;
            }

            return 0;
        }

        public int primo(Pila lista)
        {
            Nodo nodo = ultimo;
            while (nodo != null)
            {
                int num = nodo.getInfo();
                int bandera = esPrimo2(nodo.getInfo(), nodo.getInfo() - 1);

                if (bandera == 1)
                {
                    return nodo.getInfo();
                }
                nodo = nodo.getSiguiente();
            }
            return 0;
        }
    }
}
