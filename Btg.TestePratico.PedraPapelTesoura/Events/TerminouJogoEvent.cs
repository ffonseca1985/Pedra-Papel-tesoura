using System;

namespace Btg.TestePratico.PedraPapelTesoura.Events
{
    public class TerminouJogoEvent : IEvent
    {
        public DateTime Data { get; set; }
    }
}
