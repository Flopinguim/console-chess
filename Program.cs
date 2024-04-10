using console_chess.tabuleiro;
using xadrez;

namespace console_chess
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);
            tabuleiro.colocarPeca(new Torre(tabuleiro,Cor.Preta), new Posicao(0, 0));

            Tela.imprimirTabuleiro(tabuleiro);
            Console.ReadLine();
        }
    }
}
