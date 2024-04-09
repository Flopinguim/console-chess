using console_chess.tabuleiro;

namespace console_chess
{
    public class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.linhas; i++)
            {
                for (int j = 0; j < tabuleiro.colunas; j++)
                {
                    if (tabuleiro.peca(i, j) is null)
                        Console.Write("- ");
                    else
                        Console.Write(tabuleiro.peca(i, j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
