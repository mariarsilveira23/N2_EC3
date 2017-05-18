using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace n2Poo
{
    class Lista : System.Collections.IEnumerator, IEnumerable
    {
        NodoLista NodoListaAtualParaLista = null;
        NodoLista primeiro = null;
        int qtde = 0;

        public void InserirNaPosicao(NodoLista anterior,
                                     object valor)
        {
            NodoLista novo = new NodoLista();
            novo.Dado = valor;

            if (anterior == null)
            {
                if (primeiro == null)
                    primeiro = novo;
                else
                {
                    novo.Proximo = primeiro;
                    primeiro = novo;
                }
            }
            else
            {
                novo.Proximo = anterior.Proximo;
                anterior.Proximo = novo;
            }
            qtde++;
        }

        public void InserirNoInicio(object valor)
        {
            InserirNaPosicao(null, valor);
        }


        public void InserirNoFim(object valor)
        {
            if (qtde == 0)
            {
                InserirNoInicio(valor);
            }
            else
            {
                NodoLista aux = primeiro;
                while (aux.Proximo != null)
                {
                    aux = aux.Proximo;
                }
                InserirNaPosicao(aux, valor);
            }
        }


        /// <summary>
        /// Insere em uma posição, iniciando do 1
        /// </summary>
        /// <param name="valor">valor</param>
        /// <param name="posicao">posicao iniciando do 1</param>
        public void InserirNaPosicao(object valor, int posicao)
        {
            if (posicao > qtde || posicao <= 0)
                throw new Exception("Não é possível inserir.");

            if (posicao == 1)
                InserirNoInicio(valor);
            else
            {
                NodoLista aux = primeiro;
                for (int i = 1; i < posicao - 1; i++)
                    aux = aux.Proximo;

                InserirNaPosicao(aux, valor);
            }
        }


        public object RemoverDaPosicao(int posicao)
        {
            if (posicao > qtde || posicao <= 0)
                throw new Exception("Não é possível remover.");

            object valor = null;
            if (posicao == 1)
            {
                valor = primeiro.Dado;
                primeiro = primeiro.Proximo;
            }
            else
            {
                NodoLista aux = primeiro;
                for (int i = 1; i < posicao - 1; i++)
                    aux = aux.Proximo;

                valor = aux.Proximo.Dado;
                aux.Proximo = aux.Proximo.Proximo;
            }
            qtde--;
            return valor;
        }



        public bool Pesquisa(object dado, IComparer comparador)
        {
            NodoLista aux = primeiro;
            while (aux != null)
            {
                if (comparador.Compare(aux.Dado, dado) == 0)
                    return true;
                aux = aux.Proximo;
            }
            return false;
        }



        public string Listar()
        {
            string r = string.Empty;

            NodoLista aux = primeiro;
            while (aux != null)
            {
                r = r + Environment.NewLine + aux.Dado.ToString();

                aux = aux.Proximo;
            }

            return r.Trim();
        }



        public void Listar(NodoLista e)
        {
            if (e != null)
                Console.WriteLine(e.Dado);

            if (e.Proximo != null)
                Listar(e.Proximo);
        }


        public NodoLista RetornaPrimeiro()
        {
            return primeiro;
        }



        public object Current
        {
            get
            {
                if (NodoListaAtualParaLista == null)
                    return null;
                else
                    return NodoListaAtualParaLista.Dado;
            }
        }

        public bool MoveNext()
        {
            if (NodoListaAtualParaLista == null)
                NodoListaAtualParaLista = primeiro;
            else
                NodoListaAtualParaLista = NodoListaAtualParaLista.Proximo;

            bool retorno = NodoListaAtualParaLista != null;
            return retorno;
        }

        public void Reset()
        {
            NodoListaAtualParaLista = null;
        }


        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            Reset();
            return (IEnumerator)this;
        }

        #endregion
    }
}
