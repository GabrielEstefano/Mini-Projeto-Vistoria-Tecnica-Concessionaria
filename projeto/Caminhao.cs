using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto
{
    public class Caminhao:Veiculo
    {
        public int QuantidadeDeEixos {get; set;}
        public double CapacidadeCargaToneladas {get; set;}

        public Caminhao(string marca, string modelo, int ano, double quilometragem, int quantidadeDeEixos, double capacidadeCargaToneladas ):base (marca, modelo, ano, quilometragem)
        {
            this. QuantidadeDeEixos = quantidadeDeEixos;
            this. CapacidadeCargaToneladas = capacidadeCargaToneladas;
        }

        public override List<string> ObterCheckListObrigatorio()
        {
            List<string> checkList = base.ObterCheckListObrigatorio();
            checkList.Add("Tacógrafo");
            checkList.Add("Sistema de Freios a Ar");
            checkList.Add("Trava e Lona da Caçamba");
            return checkList;
        }
    }
}