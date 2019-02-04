using Btg.TestePratico.PedraPapelTesoura.Bus;
using System;

namespace Btg.TestePratico.PedraPapelTesoura
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("############### JOGO PEDRA, PAPAEL E TESOURA ################");

            Bootstrap.Initialize();
            Gateway gateway = new Gateway();

            while (true)
            {
                gateway.Comecar();
            }
        }
    }
}
