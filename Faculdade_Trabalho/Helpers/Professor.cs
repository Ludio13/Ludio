using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculdade_Trabalho.Helpers
{
    public class Professor
    {
        
        public int RA { get; set; }
        public string nome { get; set; }
        public DateTime dataDeNascimento { get; set; }
        public int CPF { get; set; }
        public int telefone { get; set; }
        public string endereco { get; set; }

        public float salario { get; set; }
        public string grau { get; set; }
        public string formacao { get; set; }

        public string cursosLecionados { get; set; }


    }
}
