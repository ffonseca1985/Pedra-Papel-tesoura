using Btg.TestePratico.PedraPapelTesoura.Handlers.Commands;
using Btg.TestePratico.PedraPapelTesoura.Handlers.Events;

namespace Btg.TestePratico.PedraPapelTesoura.Bus
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
