using Btg.TestePratico.PedraPapelTesoura.Messages.Commands;

namespace Btg.TestePratico.PedraPapelTesoura.Messages.Handlers.Commands
{
    public interface ICommandHandler<T> where T : ICommand
    {
        void Execute(T command); 
    }
}
