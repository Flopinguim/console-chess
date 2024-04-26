using console_chess.tabuleiro;

namespace xadrez
{
    public class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {

        }

        public override string ToString() => "R";

        private bool podeMover(Posicao pos)
        {
            Peca p = tabuleiro.peca(pos);
            return p is null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao posicao = new Posicao(0, 0);

            // acima
            posicao.definirValores(base.posicao.linha - 1, base.posicao.coluna);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }
            // ne
            posicao.definirValores(base.posicao.linha - 1, base.posicao.coluna + 1);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }
            // direita
            posicao.definirValores(base.posicao.linha, base.posicao.coluna + 1);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }
            // se
            posicao.definirValores(base.posicao.linha + 1, base.posicao.coluna + 1);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }
            // abaixo
            posicao.definirValores(base.posicao.linha + 1, base.posicao.coluna);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }
            // so
            posicao.definirValores(base.posicao.linha + 1, base.posicao.coluna - 1);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }
            // esquerda
            posicao.definirValores(base.posicao.linha, base.posicao.coluna - 1);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }
            // no
            posicao.definirValores(base.posicao.linha - 1, base.posicao.coluna - 1);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }
            return mat;
        }
    }
}
