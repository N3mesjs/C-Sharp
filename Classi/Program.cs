using System;

namespace Classi
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Timmy");
            Human human2 = new Human("Jeffery");
            Human human3 = new Human("Tony");

            //human.name = "CHICO"; //solo se la variabile é pubblica ci posso accedere e modificarla
            //human.walk(); //non posso usarlo con un oggetto dato che é un metodo statico quindi deve essere richiamato direttamente con la classe
            Human.walk();//metodo statico
            human1.Name();//metodo richiamato nell'oggetto di Human quindi metodo non statico

            Console.WriteLine(Human.numberOfHumans);



            Console.WriteLine("// -------------- Inheritance --------------");
            
            Macchina car = new Macchina();
            Console.WriteLine(car.ruote);
            car.Go();
        }
    }
}