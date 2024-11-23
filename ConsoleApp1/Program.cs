using System;
using System.Numerics;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      Random random = new Random();
      const string name = "Bro awda";
      Console.WriteLine("CHCIO\nawda\t"+name); //escape sequense: \(lettera in base alla funzione che serve)
      Console.WriteLine(name.ToUpper());
      Console.WriteLine(name.Insert(0, "Mr."));
      Console.WriteLine(name.Length); //lenght senza () perche é una proprietá non un metodo della classe Strin
      Console.WriteLine($"{name,-10} sei negro!"); //String interpolation $"stinga {variabile,spaziaggiuntivi(se negativo li mette a destra se no a sinistra e sono comprese nel numero il numero di lettere della variabile)}"

      double a = 3.14;
      int b = Convert.ToInt32(a);
      Console.WriteLine(b);

      double num = Math.Pow(3, 2);
      Console.WriteLine(num);
      //Console.ReadKey(); //prendo in input una lettera

      Console.WriteLine(random.Next());

      Program.Chico(); //Program. non serve dato che il metodo fa parte della stessa classe
      Console.WriteLine(Multiply(1,4,6,1,3,5));
    }

    static void Chico()
    {
      Console.WriteLine("cacca");
    }

    static double Multiply(params double[] a) //per un numero indefinito di parametri uso `params datatype[] name` questo pero potra essere l'unico tra i parametri
    {
      double total = 1;
      foreach(double num in a){
        total *= num;
      }

      return total;
    }
  }
}