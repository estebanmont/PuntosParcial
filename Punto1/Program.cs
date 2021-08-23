using System;

namespace Punto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila lista = new Pila();

            lista.apilar(2);
            lista.apilar(44);
            lista.apilar(6);
            lista.apilar(17);
            lista.apilar(72);
            lista.apilar(77);
            lista.apilar(55);
            lista.apilar(9);

            Console.WriteLine("\nApilados: ");
            lista.Visualizar();
            Console.WriteLine("Numero primo:" + " " + lista.primo(lista));
        }
    }
}
