using Btg.TestePratico.PedraPapelTesoura.Messages.Events;

namespace Btg.TestePratico.PedraPapelTesoura.Messages.Handlers.Events
{
    public interface IEventHandler<T> where T : IEvent
    {
        void Execute(T @event);
    }
}
