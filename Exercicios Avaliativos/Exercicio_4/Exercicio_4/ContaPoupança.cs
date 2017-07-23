using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class ContaPoupança : ContaCorrente
    {
        private double taxa;

        public double Taxa { get; set; }

        public ContaPoupança(string nome, int n, double s, int k, double t) : base(nome, n, s, k)
        {
            Taxa = t;
        }

        public void AtualizaSaldo()
        {
            Saldo *= taxa;
        }
    }
}
