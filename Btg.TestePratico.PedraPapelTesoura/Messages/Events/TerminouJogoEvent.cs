using System;

namespace Btg.TestePratico.PedraPapelTesoura.Messages.Events
{
    public class TerminouJogoEvent : IEvent
    {
        public DateTime Data { get; set; }
    }
}
