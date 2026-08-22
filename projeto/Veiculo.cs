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

        public int CalcularPontuacaoObtida()
        {
            int pontuacaoTotal =  0;
            foreach (ItemVistoria item in this.VistoriaRealizada)
            {
                if(item.Status == "Bom"){pontuacaoTotal = pontuacaoTotal+10;}
                else if(item.Status == "Regular"){pontuacaoTotal = pontuacaoTotal+5;}
                else if(item.Status == "Ruim"){pontuacaoTotal = pontuacaoTotal+0;}
                
            }
            return pontuacaoTotal;
        }

        public int CalcularPontuacaoMaxima()
        {return this.VistoriaRealizada.Count*10;}

        public double CalcularPercentualAprovacao()
        {
            int obtida = this.CalcularPontuacaoMaxima();
            int maxima = this.CalcularPontuacaoMaxima();
            return (double) obtida/maxima*100;
        }

        public string ClassificarEstado()
        {
            double percentual = this.CalcularPercentualAprovacao();

            if(percentual >= 90){return "Veiculo foi aprovado com exelência.";}
            else if(percentual >= 60){return "Veiculo aprovado com apontamentos.";}
            else {return "Veiculo reprovado.";}
        }

        public List<string> ObterItensCriticos()
        {
         List<string> criticos = new List<string>();

         foreach(ItemVistoria item in this.VistoriaRealizada)
            {
                if(item.Status=="Ruim"){criticos.Add(item.Nome);}   
            }
            return criticos;
        }

        public List<string> ObterItensAtencao()
        {
            List<string> atencao = new List<string>();

            foreach(ItemVistoria item in this.VistoriaRealizada)
            {
                if(item.Status=="Regular"){atencao.Add(item.Nome);}    
            }
            return atencao;
        }
    }
}