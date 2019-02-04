using System;
namespace Btg.TestePratico.PedraPapelTesoura.DomainModel.Jogo
{
    using Jogador;
    public class Jogada : IEntity<int>
    {
        public Jogador Jogador { get; private set; }
        public ITipoJogada TipoJogada { get; private set; }

        public Jogada(Jogador jogador, ITipoJogada tipoJogada)
        {
            this.Jogador = jogador;
            this.TipoJogada = tipoJogada;
        }

        public static bool Create(string text, Jogador jogador, ref Jogada jogada)
        {
            ETipoJogada tipoJogada = ETipoJogada.Papel;

            if (Enum.TryParse<ETipoJogada>(text, out tipoJogada))
            {
                try
                {
                    jogada = new Jogada(jogador, GetTipoJogada(tipoJogada));
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine("");
                    Console.WriteLine(ex.Message);
                    return false;
                }
                return true;
            }
            return false;
        }
        

        public static ITipoJogada GetTipoJogada(ETipoJogada tipoJogada)
        {

            switch (tipoJogada)
            {
                case ETipoJogada.Papel:
                    return new Papel();
                case ETipoJogada.Pedra:
                    return new Pedra();
                case ETipoJogada.Tesoura:
                    return new Tesoura();
                default:
                    throw new ApplicationException("Comando Inválido");
            }
        }

        public override bool Equals(object obj)
        {
            return this.TipoJogada == ((Jogada)obj).TipoJogada;    
        }

        public void Executar(ITipoJogada acao)
        {
            acao.Executar();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Jogador, TipoJogada);
        }
    }
}
