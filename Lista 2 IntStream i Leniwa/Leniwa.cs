using System;

namespace ConsoleApplication1
{
    class ListaLeniwa
    {
        protected int[] elementy;
        protected int rozmiar = 0;
        Random rand = new Random();

        virtual public int Element(int x)
        {
            if (rozmiar < x)
            {
                Array.Resize(ref elementy, x + 1);
                for (int i = rozmiar + 1; i <= x; i++)
                {
                    elementy[i] = rand.Next(0, 10000);
                }
                rozmiar = x;
            }
            return elementy[x];
        }

        public int Size()
        {
            return rozmiar;
        }
    }

    class Pierwsze : ListaLeniwa
    {
        bool isPrime(int x)
        {
            if (x <= 3) return true;
            if (x % 2 == 0) return false;
            for (int i = 3; i <= (x / 2 + 1); i = i + 2) if (x % i == 0) return false;
            return true;
        }

        override public int Element(int x)
        {
            if (rozmiar == 0)
            {
                Array.Resize(ref elementy, 2);
                elementy[1] = 2;
                rozmiar++;
            }
            if (rozmiar < x)
            {
                Array.Resize(ref elementy, x + 1);
                for (int i = rozmiar + 1; i <= x; i++)
                {
                    int szukana = elementy[i - 1] + 1;
                    while (!isPrime(szukana)) szukana++;
                    elementy[i] = szukana;
                    rozmiar++;
                }
            }
            return elementy[x];
        }
    }
}