using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto
{
    public class Moto:Veiculo
    {
        public int Cilindradas  {get; set;}

        public Moto(string marca, string modelo, int ano, double quilometragem, int cilindradas):base (marca, modelo, ano, quilometragem)
        {
            this. Cilindradas = cilindradas;
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