using Btg.TestePratico.PedraPapelTesoura.DomainModel.Jogo;

namespace Btg.TestePratico.PedraPapelTesoura.DomainModel.Extensions
{
    public static class JogadaExtension
    {
        public static Jogada ObterSuperior(this Jogada jogada1, Jogada jogada2)
        {
            if (jogada1 == null)
                return jogada2;

            if (jogada1.TipoJogada.TipoJogada == ETipoJogada.Papel && jogada2.TipoJogada.TipoJogada == ETipoJogada.Pedra)
                return jogada1;

            if (jogada1.TipoJogada.TipoJogada == ETipoJogada.Papel && jogada2.TipoJogada.TipoJogada == ETipoJogada.Tesoura)
                return jogada2;

            if (jogada1.TipoJogada.TipoJogada == ETipoJogada.Pedra && jogada2.TipoJogada.TipoJogada == ETipoJogada.Tesoura)
                return jogada1;

            if (jogada1.TipoJogada.TipoJogada == ETipoJogada.Pedra && jogada2.TipoJogada.TipoJogada == ETipoJogada.Tesoura)
                return jogada1;

            if (jogada1.TipoJogada.TipoJogada == ETipoJogada.Pedra && jogada2.TipoJogada.TipoJogada == ETipoJogada.Tesoura)
                return jogada1;

            if (jogada1.TipoJogada.TipoJogada == ETipoJogada.Pedra && jogada2.TipoJogada.TipoJogada == ETipoJogada.Papel)
                return jogada2;

            return jogada1;
        } 
    }
}
