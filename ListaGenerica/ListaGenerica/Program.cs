using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<int> lista = new Lista<int>();
            No<int> aux = new No<int>();
            No<int> no1 = new No<int>();
            No<int> no2 = new No<int>();
            No<int> no3 = new No<int>();
            No<int> no4 = new No<int>();
            No<int> no5 = new No<int>();
            No<int> no6 = new No<int>();
            No<int> no7 = new No<int>();
            No<int> no8 = new No<int>();
            No<int> no9 = new No<int>();
            No<int> no10 = new No<int>();

            no1.Set = 1;
            no2.Set = 2;
            no3.Set = 3;
            no4.Set = 4;
            no5.Set = 5;
            no6.Set = 6;
            no7.Set = 7;
            no8.Set = 8;
            no9.Set = 9;
            no10.Set = 10;

            lista.Adicionar(no1);
            lista.AdicionarUltimo(no2);
            lista.AdicionarUltimo(no3);
            lista.AdicionarUltimo(no4);
            lista.Adicionar(no5);
            lista.AdicionarUltimo(no6);
            lista.Adicionar(no7);
            lista.Adicionar(no8);
            lista.AdicionarUltimo(no9);
            lista.AdicionarUltimo(no10);

            lista.Remover(5);
            //imprimir a lista
            aux = lista.GSInicio;
            for (int i = 0; aux != null; i++)
            {
                Console.WriteLine("valor " + aux.Set);
                aux = aux.SetProx;
            }
        }
    }
}
