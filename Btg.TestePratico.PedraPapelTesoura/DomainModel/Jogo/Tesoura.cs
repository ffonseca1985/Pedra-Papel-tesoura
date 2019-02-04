using System;

namespace Btg.TestePratico.PedraPapelTesoura.DomainModel.Jogo
{
    public class Tesoura : ITipoJogada
    {
        public ETipoJogada TipoJogada => ETipoJogada.Tesoura;

        public void Executar()
        {
            Console.WriteLine($"Executanto: {this.TipoJogada.ToString()}");
        }
    }
}
