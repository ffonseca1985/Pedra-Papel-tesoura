using Btg.TestePratico.PedraPapelTesoura.Events;

namespace Btg.TestePratico.PedraPapelTesoura.Handlers.Events
{
    public interface IEventHandler<T> where T : IEvent
    {
        void Execute(T @event);
    }
}
