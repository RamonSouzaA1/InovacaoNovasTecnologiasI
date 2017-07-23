using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class ContaEspecial : ContaCorrente
    {
        private double limExtra;

        public double LimExtra { get; set; }

        public ContaEspecial(string nome, int n, double s, int k, double l) : base(nome, n, s, k)
        {
            LimExtra = l;
        }

        public override void Depositar(double valor)
        {
            if (valor > 0)
            {
                base.Depositar(valor);
                Console.WriteLine("Saldo Atual: {0}", this.Saldo);
            }
            else Console.WriteLine("Valor inválido");
        }

        public override Boolean Sacar(double valor)
        {
            if((this.Saldo + this.limExtra) >= valor && valor > 0)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }
        
    }
}
