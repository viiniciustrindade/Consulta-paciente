using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarPacientes
{
    public class ConsultaModel
    {
        public string nomePaciente { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string dataNasc { get; set; }
        public string mae { get; set; }
        public string prontuario { get; set; }
        public string localizacao { get; set; }
        public string leito { get; set; }
        public string situacao { get; set; }
        public int exibir { get; set; }
    }
}
