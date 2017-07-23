using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio_3
{
    class Aeroporto
    {
        public String Codigo { get; set; }
        public String Nome { get; set; }
        public Lista<Aeroporto> VooDireto = new Lista<Aeroporto>();
        public Lista<Aviao> AvioesPatio = new Lista<Aviao>();

        public Aeroporto (String cod, String nome)
        {
            Codigo = cod;
            Nome = nome;
        }

        private bool PossuiVooDireto(Aeroporto aeroporto)
        {
            if (VooDireto.Buscar(aeroporto) != -1) return true;
            else return false;
        }

        public override bool Equals(object obj)
        {
            Aeroporto aeroporto = (Aeroporto)obj;
            if (this.Codigo == aeroporto.Codigo) return true; 
            else return false;
        }

        public bool PossuiRota(Aeroporto aeroporto)
        {
            return PossuiRota(aeroporto, new Lista<Aeroporto>());
        }

        public bool PossuiRota(Aeroporto a, Lista<Aeroporto> visitados)
        {
            if (PossuiVooDireto(a)) return true;
            else
            {
                visitados.Adicionar(this);
                for(No<Aeroporto> aux = this.VooDireto.Inicio; aux != null; aux = aux.SetProx)
                {
                    if(visitados.Buscar(aux.Set) == -1)
                    {
                        if (aux.Set.PossuiRota(a, visitados)) return true;
                    }
                }
                return false;
            }
        }
    }
}
