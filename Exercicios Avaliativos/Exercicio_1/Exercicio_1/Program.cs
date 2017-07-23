using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pais p1 = new Pais("Brasil", "Brasilia", 45.000);
            Pais p2 = new Pais("Argentina", "Buenos Aires", 4.000);
            Pais p3 = new Pais("Uruguay", "Montevideu", 5.000);
            Pais p4 = new Pais("Chile", "Santiago", 10.000);

            p1.AdicionarFronteira(p2);
            p1.AdicionarFronteira(p3);

            p1.limitrofe(p2);

        }
    }
}
