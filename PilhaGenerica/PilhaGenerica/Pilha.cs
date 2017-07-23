using PilhaGenerica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaGenerica
{
    class Pilha<T>
    {
        private No<T> ultimo;

        public bool EstaVazia()
        {
            if (ultimo == null)
                return true;
            else return false;
        }

        public void Empilha(No<T> no)
        {
            if (EstaVazia())
            {
                this.ultimo = no;
                no.SetProx = null;
            }
            else
            {
                no.SetProx = this.ultimo;
                this.ultimo = no;
            }
        }

        public No<T> Desempilha()
        {
            if (EstaVazia())
            {
                return null;
            }
            else
            {
                No<T> aux = this.ultimo;
                this.ultimo = aux.SetProx;
                return aux;
            }
        }

    }
    
}
