namespace Btg.TestePratico.PedraPapelTesoura.DomainModel.Jogo
{
    public abstract class ITipoJogada
    {           
        public abstract ETipoJogada TipoJogada{ get;}
        public abstract void Executar();

        public override string ToString()
        {
            return this.TipoJogada.ToString();
        }
    }

    public enum ETipoJogada
    {
        Pedra = 1, Papel = 2, Tesoura = 3,
    }
}
