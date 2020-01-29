

namespace tabuleiro
{
   abstract class Peca//quando tem algum metodo abstrato a classe tambem tem que ser.
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }//protected so pode ser alterada por ela ou subclasse

        public int qteMovimentos { get; protected set; }//protected so pode ser alterada por ela ou subclasse

        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)//construtor
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }


        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }

        public void decrementarQteMovimentos()
        {
            qteMovimentos--;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool movimentoPossivel(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
