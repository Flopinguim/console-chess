using console_chess.tabuleiro;
using console_chess.xadrez;
using xadrez;

namespace console_chess
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PosicaoXadrez posicaoXadrez = new PosicaoXadrez('a', 1);

                Console.WriteLine(posicaoXadrez);
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }   
    }
}
