using System;

namespace Btg.TestePratico.PedraPapelTesoura.Commands
{
    public class ComecarPartidaCommand : ICommand {

        public Guid IdPartida { get; set; }
        public DateTime Data { get; set; }
    }
}
