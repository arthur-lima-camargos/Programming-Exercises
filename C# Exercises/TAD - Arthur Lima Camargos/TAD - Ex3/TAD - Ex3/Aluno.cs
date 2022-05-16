using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAD___Ex3
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public string Mail { get; set; }
        public DateTime DN { get; set; }
        public string Dia { get => DN.ToString("dd"); }
        public string Mes { get => DN.ToString("MM"); }
        public string Ano { get => DN.ToString("yyyy"); }
        public string Telefone { get; set; }

        public Aluno()
        {

        }

        public Aluno(string nome, string mail, DateTime dataNascimento, string telefone) 
        {
            this.Nome = nome;
            this.Mail = mail;
            this.DN = dataNascimento;
            this.Telefone = telefone;        
        }
    }
}
