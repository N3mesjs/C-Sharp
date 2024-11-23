using System;

namespace Classi
{
    class Veicoli
    {
        public int speed = 0;

        public void Go()
        {
            Console.WriteLine("Il veicolo é partito");
        }
    }

    class Macchina : Veicoli
    {
        public int ruote = 4;
    }
}
