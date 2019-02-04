using System;

namespace Btg.TestePratico.PedraPapelTesoura.DomainModel.Jogo
{
    public class Papel : ITipoJogada
    {
        public ETipoJogada TipoJogada => ETipoJogada.Papel;
        
        public void Executar()
        {
            Console.WriteLine($"Executanto: {this.TipoJogada.ToString()}");
        }
    }
}
