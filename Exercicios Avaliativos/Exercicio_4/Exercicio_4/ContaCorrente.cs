using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class ContaCorrente
    {
        protected int numero;
        protected double saldo;
        protected String nome;
        protected int senha;

        public  int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public ContaCorrente (String nome, int n, double s, int k)
        {
            Nome = nome;
            Numero = n;
            Saldo = s;
            Senha = k;

        }

        public virtual void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo = valor;
                Console.WriteLine("Saldo atual: {0}", Saldo);
            }
            Console.WriteLine("Valor inválido");
        }

        public virtual Boolean Sacar(double valor)
        {
            
            if(Saldo > 0 && Saldo >= valor && valor > 0)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }

    }
}
