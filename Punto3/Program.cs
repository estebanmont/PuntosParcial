using System;
using System.Collections.Generic;
using System.Linq;

namespace Punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 12, 97, 3, 77,8 };
            Dictionary<int, string> diccionario = new Dictionary<int, string>();

            for (int i = 0; i < arreglo.Length; i++)
            {
                String bandera = opciones(arreglo[i]);
                diccionario.Add(arreglo[i], bandera);
            }

            foreach (KeyValuePair<int, string> dic in diccionario)
            {
                Console.WriteLine("Clave: {0}, Valor: {1}", dic.Key, dic.Value);
            }

            Console.WriteLine("\n");

            foreach (var item in diccionario.OrderByDescending(r => r.Key))
            {
                Console.WriteLine("Clave: {0}, Valor: {1}", item.Key, item.Value);
            }
        }

        private static string opciones(int numero)
        {
            if (numero % 2 == 0)
            {
                return "2";
            }
            else if (numero % 3 == 0)
            {
                return "3";
            }
            else if (numero % 5 == 0)
            {
                return "5";
            }
            else if (numero % 7 == 0)
            {
                return "7";
            }
            else
            {
                return "Primo";
            }
        }
    }
}
