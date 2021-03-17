using tabuleiro;
using System;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
          
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {

                    Console.Clear();
                    Tela.iprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    Console.WriteLine("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }

                Tela.iprimirTabuleiro(partida.tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

           
        }
    }
}
