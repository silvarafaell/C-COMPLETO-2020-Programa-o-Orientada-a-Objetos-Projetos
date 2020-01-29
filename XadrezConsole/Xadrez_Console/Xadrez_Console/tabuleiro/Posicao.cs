

namespace tabuleiro
{
    class Posicao
    {
        public int linha { get; set; }//encapsulamento
        public int coluna { get; set; }//encapsulamento

        public Posicao(int linha, int coluna)//construtores
        {
            this.linha = linha;//this tem em construtores
            this.coluna = coluna;
                 
        }

        public void definirValores(int linha, int coluna)
        {
            this.linha = linha;//this tem em construtores
            this.coluna = coluna;
        }
        public override string ToString()
        {
            return linha
                + ", "
                + coluna;
        }
    }
}
