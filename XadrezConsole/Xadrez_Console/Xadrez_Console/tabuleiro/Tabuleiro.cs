
namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set;}

        private Peca[,] pecas;//matriz de pecas

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];//matriz

        }

        public Peca peca(int linha, int coluna)//para poder acessar peca, estava acima private
        {
            return pecas[linha, coluna];
        }

        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Posicao pos)//teste se existe uma peca em uma dada posicao
        {
            validarPosicao(pos);
            return peca(pos) != null; //diferente de nulo
        }

        public void colocarPeca(Peca p, Posicao pos)//colocar uma peca
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("já existe uma peça nessa Posição!");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }


        public Peca retirarPeca(Posicao pos)
        {
            if(peca(pos) == null)
            {
                return null;
            }

            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }

        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas) // || é ou
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posicao Invalida");//se a posicao passada não for valida ira passar uma excessao
            }
        }
    }
}
