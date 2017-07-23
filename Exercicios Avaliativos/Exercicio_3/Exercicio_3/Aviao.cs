using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Aviao
    { 
        public string Prefixo { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public int QuantdAssentos { get; set; }
        public int QuantdAssentosOcupado { get; set; }

        public Aviao(string prefixo, string fabricante, string modelo, int assentos)
        {
            Prefixo = prefixo;
            Fabricante = fabricante;
            Modelo = modelo;
            QuantdAssentos = assentos;
        }

    }
}
