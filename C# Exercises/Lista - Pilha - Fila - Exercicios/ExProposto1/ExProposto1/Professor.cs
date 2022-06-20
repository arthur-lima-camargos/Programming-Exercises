using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExProposto1
{
    internal class Professor
    {
        public string Código { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Mail { get; set; }
        public Professor Próx;

        public Professor()
        {
            this.Código = Guid.NewGuid().ToString().Substring(9, 4).ToUpper();
            Próx = null;
        }
    }
}
