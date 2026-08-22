using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace projeto
{
    public class Carro:Veiculo
    {
        public int QuantidadeDePortas {get; set;}

        public Carro(string marca, string modelo, int ano, double quilometragem, int quantidadeDePortas):base (marca, modelo, ano, quilometragem)
        {
            this. QuantidadeDePortas = quantidadeDePortas;
        }

        public override List<string> ObterCheckListObrigatorio()
        {
            List<string> checkList = base.ObterCheckListObrigatorio();
            checkList.Add("Estepe e Macaco");
            checkList.Add("Triângulo de sinalização");
            checkList.Add("Ar-Condicionado Funcional");
            return checkList;
        }
    }
}