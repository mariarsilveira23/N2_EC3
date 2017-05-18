using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n2Poo
{
    class NodoLista
    {
        object dado;

        public object Dado
        {
            get { return dado; }
            set { dado = value; }
        }

        NodoLista proximo;

        public NodoLista Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }


        /// <summary>
        /// Construtor parametrizado
        /// </summary>
        /// <param name="dado"></param>
        /// <param name="proximo"></param>
        public NodoLista(int dado, NodoLista proximo)
        {
            this.dado = dado;
            this.proximo = proximo;
        }

        /// <summary>
        /// construtor sem parâmetros
        /// </summary>
        public NodoLista()
        {
            proximo = null;
        }
    }
}
