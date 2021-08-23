using System;
using System.Collections.Generic;

namespace SegundoPünto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            lista.Add(2);
            lista.Add(44);
            lista.Add(56);
            lista.Add(1);

            lista = Ordenar(lista);

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            buscar(56, lista);

        }

        public static List<int> Ordenar(List<int> list)
        {
            int aux = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        aux = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = aux;
                    }
                }
            }
            return list;
        }

        public static void buscar(int numero, List<int> lista)
        {
            Boolean bandera = false;
            for (int i = 0; i < lista.Count; i++)
            {
                if (numero == lista[i])
                {
                    bandera = true;
                }
            }

            if (bandera == true)
            {
                Console.WriteLine("El numero" + " " + numero + " " + "se encuentra en el arreglo");
            }
            else
            {
                Console.WriteLine("El numero no se encuentra en el arreglo");
            }
        }

    }
}
       

