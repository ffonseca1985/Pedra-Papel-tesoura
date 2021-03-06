﻿using System;

namespace Btg.TestePratico.PedraPapelTesoura.DomainModel.Jogo
{
    public class Tesoura : ITipoJogada
    {
        public override ETipoJogada TipoJogada => ETipoJogada.Tesoura;

        public override void Executar()
        {
            Console.WriteLine($"Comando Executado: {this.TipoJogada.ToString()}");
        }
    }
}
