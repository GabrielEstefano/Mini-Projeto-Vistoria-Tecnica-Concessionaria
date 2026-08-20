using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto
{
    public abstract class Veiculo
    {
        public string Marca {get; set;}
        public string Modelo {get; set;}
        public int Ano {get; set;}
        public double Quilometragem {get; set;}
        public List<ItemVistoria> VistoriaRealizada {get; set;}

        public Veiculo (string marca, string modelo, int ano, double quilometragem)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
            this.Quilometragem = quilometragem;
            this.VistoriaRealizada = new List<ItemVistoria>();
        }

        public void AdicionarItemVistoriado(string nome, string status)
        {
            ItemVistoria item = new ItemVistoria(nome,status);
            this.VistoriaRealizada.Add(item);
        }
        public virtual List<string> ObterCheckListObrigatorio()
        {
            return new List<string>
            {"Nível de óleo no motor",
             "Bateria e sistema Elétrico", 
             "Documentação regularizada",};
        }
    }
}