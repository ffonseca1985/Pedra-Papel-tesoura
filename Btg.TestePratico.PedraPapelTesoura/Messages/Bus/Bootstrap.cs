using Btg.TestePratico.PedraPapelTesoura.Messages.Handlers.Commands;
using Btg.TestePratico.PedraPapelTesoura.Messages.Handlers.Events;

namespace Btg.TestePratico.PedraPapelTesoura.Messages.Bus
{
    public class Bootstrap
    {
        public static void Initialize() {

            BusInMemory.RegisterCommands<AdicionarJogadasCommandHandler>();
            BusInMemory.RegisterCommands<AdicionarJogadoresCommandHandler>();
            BusInMemory.RegisterCommands<ComecarPartidaCommandHandler>();

            BusInMemory.RegisterEvents<TerminouJovoEventHandler>();
        }
    }
}
