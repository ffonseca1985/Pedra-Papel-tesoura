namespace Btg.TestePratico.PedraPapelTesoura.DomainModel.Jogo
{
    public interface ITipoJogada
    {           
        ETipoJogada TipoJogada{ get; }
        void Executar();
    }

    public enum ETipoJogada
    {
        Pedra = 1, Papel = 2, Tesoura = 3,
    }
}
