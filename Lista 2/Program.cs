using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaLeniwa proba1 = new ListaLeniwa();
            Console.WriteLine(proba1.Element(20));
            Console.WriteLine(proba1.Element(15));
            Console.WriteLine(proba1.Element(15));
            Console.WriteLine(proba1.Element(25));
            Console.WriteLine(proba1.Element(20));

            Console.WriteLine();

            Pierwsze proba2 = new Pierwsze();
            Console.WriteLine(proba2.Element(20));
            Console.WriteLine(proba2.Element(15));
            Console.WriteLine(proba2.Element(15));
            Console.WriteLine(proba2.Element(25));
            Console.WriteLine(proba2.Element(20));

            Console.WriteLine();

            IntStream proba3 = new IntStream();
            Console.WriteLine(proba3.Next());
            Console.WriteLine(proba3.Next());
            Console.WriteLine(proba3.Next());
            Console.WriteLine(proba3.Next());
            Console.WriteLine(proba3.Next());

            Console.WriteLine();

            PrimeStream proba4 = new PrimeStream();
            Console.WriteLine(proba4.Next());
            Console.WriteLine(proba4.Next());
            Console.WriteLine(proba4.Next());
            Console.WriteLine(proba4.Next());
            Console.WriteLine(proba4.Next());

            Console.WriteLine();

            RandomWordStream proba5 = new RandomWordStream();
            proba5.Next();
            proba5.Next();
            proba5.Next();
            proba5.Next();
            proba5.Next();
            Console.ReadLine();
        }
    }
}
