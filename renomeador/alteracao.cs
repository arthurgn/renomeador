using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renomeador
{
    class alteracao
    {
        public alteracao()
        {

        }
        public alteracao(string antigo, string novo)
        {
            this.antigo = antigo;
            this.novo = novo;
        }

        public string antigo { get; set; }
        public string novo { get; set; }
    }
}
