using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio_1
{
    class Pais
    {
        private String nome;
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private String capital;
        public String Capital
        {
            get { return capital; }
            set { capital = value; }
        }
        private double dimensao;
        public double Dimensao
        {
            get { return dimensao; }
            set { dimensao = value; }

        }
        private Lista<Pais> fronteiras;
        public Lista<Pais> Fronteiras
        {
            get { return fronteiras; }
            set { fronteiras = value; }
        }

        public Pais (String nome, String capital, double dimensao)
        {
            Nome = nome;
            Capital = capital;
            Dimensao = dimensao;
        }

        public override bool Equals(object obj)
        {
            Pais pais = (Pais)obj;

            if (this.nome == pais.nome && this.capital == pais.capital)
            { return true; }
            else
            {
                return false;
            }
        }

        public bool FazLimite(Pais pais)
        {
            if (this.fronteiras.Buscar(pais) != -1)
            {
                return true;
            }
            else return false;
        }

        public Lista<Pais> Vizinhos(Pais pais)
        {
            Lista<Pais> vizinhos = new Lista<Pais>();
            int i, j;
            for(i=0; i<this.fronteiras.Size; i++){
                for (j = 0; j < pais.Fronteiras.Size; j++)
                {
                    if (this.Fronteiras.BuscarPorIndice(i).Equals(pais.Fronteiras.BuscarPorIndice(j))){
                        vizinhos.Adicionar(pais.Fronteiras.BuscarPorIndice(j));
                    }
                }
            }
            return vizinhos;
        }

        public void AdicionarFronteira(Pais vizinho)
        {
            this.fronteiras.Adicionar(vizinho);
        }

    }
}
