using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aviao boeing = new Aviao("Boeing", "Bmw", "BOI", 2);
            Aviao teco = new Aviao("Teco-teco", "Fiat", "TEC", 2);
            Aviao jato = new Aviao("Jato", "Vw", "JTO", 2);
            Aviao caça = new Aviao("Caça", "Chevrolet", "CA", 2);
            Aviao aviao = new Aviao("747", "Hiundai", "747", 2);
            Aviao planador = new Aviao("Planador", "Sony", "PLR", 2);
            Aeroporto brasilia = new Aeroporto("Brasilia", "BRS");
            Aeroporto manaus = new Aeroporto("Manaus", "MAN");
            Aeroporto belem = new Aeroporto("Belem", "BEL");
            Aeroporto Belo = new Aeroporto("Belo Horizonte", "BHO");
            Aeroporto rio = new Aeroporto("Rio de Janeiro", "RIO");
            Aeroporto saoPaulo = new Aeroporto("São Paulo", "SPA");
            Aeroporto saoLuis = new Aeroporto("São Luis", "SLU");
            Aeroporto curitiba = new Aeroporto("Curitiba", "CBA");
            Aeroporto goiania = new Aeroporto("Goiânia", "GOI");
            Aeroporto juizdefora = new Aeroporto("Juiz de Fora", "JFO");
            Aeroporto barbacena = new Aeroporto("Juiz de Fora", "JFO");

            
            brasilia.AvioesPatio.Adicionar(teco);
            brasilia.AvioesPatio.Adicionar(jato);
            brasilia.AvioesPatio.Adicionar(planador);
            brasilia.AvioesPatio.Adicionar(aviao);
            manaus.AvioesPatio.Adicionar(teco);
            manaus.AvioesPatio.Adicionar(jato);
            manaus.AvioesPatio.Adicionar(caça);
            manaus.AvioesPatio.Adicionar(boeing);
            belem.AvioesPatio.Adicionar(teco);
            Belo.AvioesPatio.Adicionar(jato);
            belem.AvioesPatio.Adicionar(planador);
            Belo.AvioesPatio.Adicionar(aviao);
            belem.AvioesPatio.Adicionar(teco);
            Belo.AvioesPatio.Adicionar(jato);
            belem.AvioesPatio.Adicionar(caça);
            Belo.AvioesPatio.Adicionar(boeing);
            saoPaulo.AvioesPatio.Adicionar(teco);
            rio.AvioesPatio.Adicionar(jato);
            saoLuis.AvioesPatio.Adicionar(planador);
            saoPaulo.AvioesPatio.Adicionar(aviao);
            rio.AvioesPatio.Adicionar(teco);
            saoPaulo.AvioesPatio.Adicionar(jato);
            rio.AvioesPatio.Adicionar(caça);
            saoLuis.AvioesPatio.Adicionar(boeing);
            saoPaulo.AvioesPatio.Adicionar(teco);
            rio.AvioesPatio.Adicionar(jato);
            curitiba.AvioesPatio.Adicionar(planador);
            rio.AvioesPatio.Adicionar(aviao);
            saoLuis.AvioesPatio.Adicionar(teco);
            saoPaulo.AvioesPatio.Adicionar(jato);
            rio.AvioesPatio.Adicionar(caça);
            saoPaulo.AvioesPatio.Adicionar(boeing);
            curitiba.AvioesPatio.Adicionar(teco);
            curitiba.AvioesPatio.Adicionar(jato);
            curitiba.AvioesPatio.Adicionar(caça);
            curitiba.AvioesPatio.Adicionar(boeing);
            goiania.AvioesPatio.Adicionar(teco);
            goiania.AvioesPatio.Adicionar(jato);
            goiania.AvioesPatio.Adicionar(caça);
            goiania.AvioesPatio.Adicionar(boeing);

            brasilia.VooDireto.Adicionar(goiania);
            brasilia.VooDireto.Adicionar(Belo);
            brasilia.VooDireto.Adicionar(rio);
            manaus.VooDireto.Adicionar(belem);
            manaus.VooDireto.Adicionar(saoPaulo);
            belem.VooDireto.Adicionar(rio);
            Belo.VooDireto.Adicionar(belem);
            rio.VooDireto.Adicionar(saoLuis);
            saoPaulo.VooDireto.Adicionar(rio);
            saoPaulo.VooDireto.Adicionar(brasilia);
            saoLuis.VooDireto.Adicionar(saoPaulo);
            curitiba.VooDireto.Adicionar(rio);
            goiania.VooDireto.Adicionar(saoPaulo);
            barbacena.VooDireto.Adicionar(juizdefora);
            juizdefora.VooDireto.Adicionar(curitiba);
            
            if (juizdefora.PossuiRota(rio))
            {
                Console.WriteLine("possui rota");
            }
            else Console.WriteLine("Nao possui");
            

        }
    }
}
