namespace console_chess.tabuleiro
{
    public class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna) => pecas[linha, coluna];

        public Peca peca(Posicao posicao) => pecas[posicao.linha, posicao.coluna];

        public bool existePeca(Posicao posicao)
        {
            validarPosicao(posicao);
            return peca(posicao) != null;
        }
        public void colocarPeca(Peca peca, Posicao posicao)
        {
            if (existePeca(posicao))
                throw new TabuleiroException("Já existe uma peça nessa posição!");

            pecas[posicao.linha, posicao.coluna] = peca;
            peca.posicao = posicao;
        }

        public Peca retirarPeca(Posicao posicao)
        {
            if (peca(posicao) is null)
                return null;

            Peca aux = peca(posicao);
            aux.posicao = null;
            pecas[posicao.linha, posicao.coluna] = null;
            return aux;
        }

        public bool posicaoValida(Posicao pos) => !(pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas);

        public void validarPosicao(Posicao posicao)
        {
            if (!posicaoValida(posicao))
                throw new TabuleiroException("Posição inválida!");
        }
    }
}