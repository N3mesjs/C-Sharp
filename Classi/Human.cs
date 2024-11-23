using System;

namespace Classi 
{
    class Human //specifico static se voglio avere solo metodi statici all'interno della classe e quindi non voglio oggeti
    {
        string name;
        public static int numberOfHumans; // la faccio statica in modo da poterci accedere con la classe e non con gli oggetti specifici in modo che il counter funzioni in modo adeguato

        public Human(string name) //ricorda se non lo specifico verra creato un metodo costruttore in automatico
        {
            this.name = name;
            numberOfHumans++;
        }
        static public void walk()
        {
            Console.WriteLine("wdada is walking!");
        }

        public void Name()
        {
            Console.WriteLine($"{name}");
        }
    }
}