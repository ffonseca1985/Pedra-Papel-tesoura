using System;

namespace Btg.TestePratico.PedraPapelTesoura.DomainModel.Jogo
{
    public class Pedra : ITipoJogada
    {
        public ETipoJogada TipoJogada => ETipoJogada.Pedra;

        public void Executar()
        {
            Console.WriteLine($"Executanto: {this.TipoJogada.ToString()}");
        }
    }
}
