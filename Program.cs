using System;
using DesafioDotNET.src.Entities;

namespace DesafioDotNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            Ninja ninja = new Ninja("Wedge", 35, "Ninja");
            BlackWizard bw = new BlackWizard("Topapa", 52, "Black Wizard");

            Console.WriteLine(wizard.Attack(1)); 
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(bw.Attack(8));
        }
    }
}

