using System.Collections.Generic;

namespace renomeador
{
    class configuracao
    {
        public configuracao()
        {

        }

        public List<alteracao> alteracoes { get; set; }
        public bool maisculo { get; set; }
        public bool minusculo { get; set; }
        public string diretorio { get; set; }
        public bool removerseigual { get; set; }
    }
}
