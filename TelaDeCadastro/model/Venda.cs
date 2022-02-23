using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaDeCadastro.model
{
    public class Venda
    {
        public Cliente _id { get; set; }
        public Int64 id { get; set; }
        public string nomeProduto { get; set; }
        public string nomeVendedor { get; set; }
        public string unidade { get; set; }
        public string quantidade { get; set; }
        public string precoUnitario { get; set; }
        public string valorTotal { get; set; }

        
       
    }
}
