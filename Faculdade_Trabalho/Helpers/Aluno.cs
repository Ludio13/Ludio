using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculdade_Trabalho.Helpers
{
    public class Aluno
    {
        public int RA { get; set; }
        public string nome { get; set; }
        public DateTime dataDeNascimento { get; set; }
        public int CPF { get; set; }
        public int CEP { get; set; }
        public int telefone { get; set; }
        public string endereco { get; set; }
        public string Pai { get; set; }
        public string Mae { get; set; }

        public string cursosMatriculado { get; set; }
    }
}
