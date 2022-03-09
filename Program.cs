// See https://aka.ms/new-console-template for more information
using System;
using Projeto_jogo_RPG.src.Entities;

namespace Projeto_jogo_RPG
{
    class Program
    {
        static void Main(String[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
        }
    }
}


