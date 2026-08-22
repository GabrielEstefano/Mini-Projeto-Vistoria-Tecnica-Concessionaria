using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto
{
    public class ItemVistoria
    {
        public string Nome {get; set;}
        private string status;
        public string Status
        {
            get {return status; }
            set
            {
                if(value == "Bom" || value == "Regular" || value =="Ruim")
                {status = value;}
                else
                {Console.WriteLine("Use apenas: Bom, Regular ou Ruim.");}
            }
        }
        public ItemVistoria(string nome, string statusObj)
        {
            this.Nome = nome;
            this.Status = statusObj;
        }
    }
} 