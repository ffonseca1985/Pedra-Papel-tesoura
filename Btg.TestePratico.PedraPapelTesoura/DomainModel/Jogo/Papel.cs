using System;

namespace Btg.TestePratico.PedraPapelTesoura.DomainModel.Jogo
{
    public class Papel : ITipoJogada
    {
        public override ETipoJogada TipoJogada => ETipoJogada.Papel;
        
        public override void Executar()
        {
            Console.WriteLine($"Executanto: {this.TipoJogada.ToString()}");
        }
    }
}
