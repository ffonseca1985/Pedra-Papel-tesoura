﻿using System;

namespace Btg.TestePratico.PedraPapelTesoura.DomainModel.Jogo
{
    public class Pedra : ITipoJogada
    {
        public override ETipoJogada TipoJogada => ETipoJogada.Pedra;

        public override void Executar()
        {
            Console.WriteLine($"Comando Executado: {this.TipoJogada.ToString()}");
        }
    }
}
