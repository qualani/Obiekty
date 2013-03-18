using System;

namespace ConsoleApplication1
{
    class IntStream
    {
        protected Random rand = new Random();
        protected int strumien = -1;

        virtual public int Next()
        {
            if (!Eos()) strumien++;
            return strumien;
        }

        virtual public bool Eos()
        {
            if (strumien >= 1000) return true; else return false;
        }

        public void Reset()
        {
            strumien = -1;
        }
    }

    class PrimeStream : IntStream
    {
        bool isPrime(int x)
        {
            if (x < 2) return false;
            if (x == 2) return true;
            if (x % 2 == 0) return false;
            for (int i = 3; i <= (x / 2 + 1); i = i + 2) if (x % i == 0) return false;
            return true;
        }

        override public int Next()
        {
            if (!Eos()) strumien = nextPrime();
            return strumien;
        }

        override public bool Eos()
        {
            if (strumien + 1 < 0) return true; else return false;
        }

        int nextPrime()
        {
            int szukana = strumien + 1;
            while (!isPrime(szukana))
            {
                szukana++;
            }
            return szukana;
        }
    }

    class RandomStream : IntStream
    {
        override public int Next()
        {
            strumien = rand.Next(0, 1000);
            return strumien;
        }

        override public bool Eos()
        {
            return false;
        }
    }

    class RandomWordStream
    {
        RandomStream rand = new RandomStream();
        PrimeStream prime = new PrimeStream();
        int strumien_prime;

        public bool Eos()
        {
            return prime.Eos();
        }

        public void Next()
        {
            strumien_prime = prime.Next();
            for (int i = 0; i < strumien_prime; i++)
            {
                int losowy = rand.Next();
                Console.Write(losowy % 10);
            }
            Console.WriteLine();
        }
    }
}