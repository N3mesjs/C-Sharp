using System;
using System.Numerics;

namespace RSA
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            byte[] bytes = new byte[2048]; // Adjust size as needed
            random.NextBytes(bytes);
            BigInteger randomBigInteger = new BigInteger(bytes);
            Console.WriteLine("Random BigInteger: " + randomBigInteger);
        }
    }
}