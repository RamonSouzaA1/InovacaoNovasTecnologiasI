using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Aviao
    { 
        public string prefixo { get; set; }
        public string fabricante { get; set; }
        public int qtdAssentos { get; set; }
        public int qtdAssentosOcupados { get; set; }

        public Aviao(string prefixo, string fabricante, int assentos)
        {
            prefixo = prefixo;
            fabricante = fabricante;
            qtdAssentos = assentos;
        }

    }
}
