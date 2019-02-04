namespace Btg.TestePratico.PedraPapelTesoura.DomainModel
{
    public abstract class IEntity<T> 
    {
        public T Id { get; set; }
    }
}
