using System;
using System.Collections.Generic;
using System.Linq;

namespace TutorialProgramacion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            List<int> lista2 = new List<int>
            {
                3,4,5,6,7, 8, 9, 11, 15
            };
            //numeros = LlenarListaSinPasarleParametro();
            //LlenarListaPasandoleParametro(listaNegativa, -10, -1);
            LlenarListaPasandoleParametro(numeros, 5, 15);            
            MostrarNumeros(numeros, lista2);
        }

        public static void MostrarNumeros(List<int> listadoNumeros, List<int> otraLista)
        {
            listadoNumeros.Sort();
            otraLista.Sort();
            while(listadoNumeros.Count > 0 && otraLista.Count > 0)
            {
                int elementoListadoNumeros = listadoNumeros.First();
                int elementoOtraLista = otraLista.First();
                if(elementoListadoNumeros > elementoOtraLista)
                {
                    Console.WriteLine("El {0} de la lista llamda listadoNumeros es el mayor", elementoListadoNumeros);
                    listadoNumeros.Remove(elementoListadoNumeros);
                }
                else
                {
                    Console.WriteLine("El {0} de la lista llamda otraLista es el mayor", elementoOtraLista);
                    otraLista.Remove(elementoOtraLista);
                }                
            }
            if(otraLista.Count > 0)
            {
                foreach(int elemento in otraLista)
                    Console.WriteLine("El {0} de la lista llamda otraLista es el mayor", elemento);
            }
            else
            {
                foreach (int elemento in listadoNumeros)
                    Console.WriteLine("El {0} de la lista llamda listadoNumeros es el mayor", elemento);
            }            
            Console.ReadLine();
        }

        public static void LlenarListaPasandoleParametro(List<int> lista, int inicial, int finCicloFor)
        {
            for (int i = inicial; i <= finCicloFor; i++)
            {
                lista.Add(i);
            }
        }

        public static List<int> LlenarListaSinPasarleParametro()
        {
            List<int> listaAux = new List<int>();
            for(int i=1; i<=10; i++)
            {
                listaAux.Add(i);
            }
            return listaAux;
        }
    }
}
