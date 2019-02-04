
using Btg.TestePratico.PedraPapelTesoura.Commands;
using System.Runtime.InteropServices;

namespace Btg.TestePratico.PedraPapelTesoura.Handlers.Commands
{
    public interface ICommandHandler<T> where T : ICommand
    {
        void Execute(T command); 
    }
}
