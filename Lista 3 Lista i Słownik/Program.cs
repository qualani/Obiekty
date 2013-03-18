using System;
using ClassLibrary1;
using System.Diagnostics;
using ClassLibrary2;

namespace ConsoleApplication1
{
    class Program
    {

        static void TestLista()
        {
            MojaLista<int> lista = new MojaLista<int>();

            lista.Append(3);
            lista.Append(4);
            lista.Append(5);
            lista.Insert(2);
            lista.Insert(1);
            lista.Drukarka();

            Console.WriteLine();

            if (!lista.IsEmpty)
                Console.WriteLine(lista.RemoveEnd());

            Console.WriteLine();

            if (!lista.IsEmpty)
                lista.RemoveStart();
            lista.Drukarka();

            Console.WriteLine();

            MojaLista<string> lista2 = new MojaLista<string>();

            lista2.Append("DZIALA");
            lista2.Append("JAK");
            lista2.Append("FAJNIE");
            lista2.Insert("TO");
            lista2.Insert("OJEJ");
            lista2.Drukarka();

            Console.WriteLine();

            MojaLista<int> lista3 = new MojaLista<int>();
            lista3.Append(1);
            lista3.Append(2);
            lista3.RemoveEnd();
            lista3.RemoveStart();
            lista3.Drukarka();

            Console.WriteLine();
        }

        static void TestSlownik()
        {
            Zad2Słownik<int, string> slownik = new Zad2Słownik<int, string>();

            slownik.Add(1, "jeden");
            slownik.Add(2, "dwa");
            slownik.Add(3, "trzy");
           //slownik.Add(1, "jeden");
            string s;
            Console.WriteLine(slownik.Search(2, out s));
            Console.WriteLine(slownik.Search(5, out s));
            slownik.Remove(2);
            Console.WriteLine(slownik.Remove(5));
            slownik.Drukarka();

            Console.WriteLine();

            Zad2Słownik<int, string> slownik2 = new Zad2Słownik<int, string>();
            slownik2.Add(1, "jeden");
            slownik2.Remove(1);
            slownik2.Drukarka();

        }

        static void Main()
        {
            TestLista();
            TestSlownik();
            Console.ReadLine();
        }
    }
}
