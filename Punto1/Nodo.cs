using System;
using System.Collections.Generic;
using System.Text;

namespace Punto1
{
    class Nodo
    {
        private int info;
        private Nodo siguiente;

        public Nodo()
        {
            info = 0;
            siguiente = null;
        }

        public Nodo(int info)
        {
            this.info = (int)info;
            siguiente = null;
        }

        public Nodo(int info, Nodo n)
        {
            this.info = (int)info;
            siguiente = n;
        }

        public int getInfo()
        {
            return info;
        }

        public void setInfo(int info)
        {
            this.info = info;
        }

        public Nodo getSiguiente()
        {
            return siguiente;
        }

        public void setSiguiente(Nodo siguiente)
        {
            this.siguiente = siguiente;
        }


        public String toString()
        {
            return "Nodo{" + "info=" + info + ", enlace=" + siguiente + '}';
        }


    }
}
