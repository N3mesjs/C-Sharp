using System;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      Random random = new Random();
      const String name = "Bro";
      Console.WriteLine("CHCIO\nawda\t"+name); //escape sequense: \(lettera in base alla funzione che serve)

      double a = 3.14;
      int b = Convert.ToInt32(a);
      Console.WriteLine(b);

      double num = Math.Pow(3, 2);
      Console.WriteLine(num);
      //Console.ReadKey(); //prendo in input una lettera

      Console.WriteLine(random.Next());
    }
  }
}