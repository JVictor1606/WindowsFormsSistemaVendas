using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaDeCadastro.model
{
    public class Cliente
    {
        public Int64 id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public DateTime dataNascimento { get; set; }
        public char sexo { get; set; }
    }
}
