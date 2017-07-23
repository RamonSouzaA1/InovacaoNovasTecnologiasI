using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Exercicio_1
{
    class Lista<T>
    {
        private No<T> inicio;
        public No<T> Inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }
        private No<T> ultimo;
        public No<T> Ultimo
        {
            get { return ultimo; }
            set { ultimo = value; }
        }
        private int size = 0;
        public int Size { get; set; }

        public int Buscar(T item)
        {
            No<T> aux = new No<T>();
            aux = inicio;
            int index = 0;

            for (int i = 0; aux != null; i++)
            {

                if (item.Equals(aux.Set))
                {
                    return index;
                }

                aux = aux.SetProx;
                index++;
            }

            return -1;
        }

        public T BuscarPorIndice(int idx)
        {
            No<T> aux = new No<T>();
            aux = inicio;
            int index = 0;

            for (int i = 0; i < this.Size; i++)
            {
                if (idx == index)
                {
                    return aux.Set;
                }
                aux = aux.SetProx;
            }
            return default(T);
        }
        
        public void Adicionar(T item)
        {
            No<T> novo = new No<T>();
            novo.Set = item;
           
            if (inicio == null)
            {
                inicio = novo;
                ultimo = novo;
            }
            else
            {
                No<T> aux = new No<T>();
                aux = inicio;
                inicio = novo;
                inicio.SetProx = aux;
            }
            size++;
        }

        public void AdicionarUltimo(T no)
        {
            No<T> item = new No<T>();
            item.Set = no;

            if (inicio == null)
            {
                inicio = item;
                ultimo = item;
            }
            else
            {
                No<T> aux = new No<T>();
                aux = ultimo;
                ultimo = item;
                aux.SetProx = ultimo;
            }
            size++;
        }

        public void Remover(T no)
        {
            No<T> item = new No<T>();
            item.Set = no;
            No<T> aux = new No<T>();
            No<T> anterior = new No<T>();
            aux = inicio;

            for (int i = 0; aux != null; i++)
            {

                if (anterior != null)
                {
                    if (item == aux)
                    {

                        inicio = aux.SetProx;
                    }
                    anterior = aux;
                    aux = aux.SetProx;

                }
                else
                {
                    if (item == aux)
                    {

                        inicio = inicio.SetProx;
                    }

                }

            }
            size--;
        }

        public void RemoverPorIndice(int id)
        {
            No<T> aux = new No<T>();
            No<T> anterior = new No<T>();
            aux = inicio;
            int index = 0;

            for (int i = 0; aux != null; i++)
            {

                if (anterior != null)
                {
                    if (id == index)
                    {

                        inicio = aux.SetProx;
                    }
                    anterior = aux;
                    aux = aux.SetProx;
                    index++;
                }
                else
                {
                    if (id == index)
                    {
                        inicio = inicio.SetProx;
                    }

                }
            }
            size--;
        }
    }
}
