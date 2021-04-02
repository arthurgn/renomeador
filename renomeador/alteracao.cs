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
