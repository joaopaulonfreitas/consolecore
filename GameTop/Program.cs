﻿using System;
using GameTop.Lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda(
                new Jogador1("João Paulo do Nascimento Freitas"),
                new Jogador3("José Nacilio Freitas")
            );

            jogo.IniciarJogo();
        }
    }
    
}
