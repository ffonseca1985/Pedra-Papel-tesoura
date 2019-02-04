using System;

namespace Btg.TestePratico.PedraPapelTesoura.Messages.Commands
{
    public class ComecarPartidaCommand : ICommand {

        public Guid IdPartida { get; set; }
        public DateTime Data { get; set; }
    }
}
