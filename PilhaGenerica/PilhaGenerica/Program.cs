using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha<int> pilha = new Pilha<int>();
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

            pilha.Empilha(no1);
            pilha.Empilha(no2);
            pilha.Empilha(no3);
            pilha.Empilha(no4);
            pilha.Empilha(no5);

            No<int> aux = new No<int>();

            while (!pilha.EstaVazia()) 
            {
                aux = pilha.Desempilha();
                Console.WriteLine("valor " + aux.Set);
            }


        }
    }
}
