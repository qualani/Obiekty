using System;
using System.Collections;

namespace Lista3
{

    interface IZad
    {
        bool Wstaw(int elem);
        bool Szukaj(int elem);
    }

    //klasa dla zbioru (tu są elementy bez powtórzeń)
    public class Zbior : IZad
    {
        public int Length = 0;
        public int[] Tablica = new int[100];

        //funkcja wstawiania elementu i szukania
        public bool Wstaw(int elem)
        {
            if (Szukaj(elem) || Length == 100) return false;
            Tablica[Length] = elem;
            Length++;
            return true;
        }

        public bool Szukaj(int elem)
        {
            for (int i = 0; i <= Length; i++)
                if (Tablica[i] == elem) return true;
            return false;
        }
    }

    //klasa dla torby (elementy z powtórzeniami)
    public class Torba : IZad, IEnumerable
    {
        public int Length = 0;
        public int[] Tablica = new int[100];

        //funkcja wstawiania i szukania elementu
        public bool Wstaw(int elem)
        {
            if (Length == 100) return false;
            Tablica[Length] = elem;
            Length++;
            return true;
        }

        public bool Szukaj(int elem)
        {
            for (int i = 0; i <= Length; i++)
                if (Tablica[i] == elem) return true;
            return false;
        }

        //nowy ToString i IEnumerator

        public override string ToString()
        {
            string retr = "";
            for (int i = 0; i <= Length; i++)
                retr += Tablica[i];
            return retr;
        }

        public IEnumerator GetEnumerator()
        {
            int it = 1;
            foreach (int elem in Tablica)
            {
                if (it > Length) break;
                it++;
                yield return elem;
            }
        }
    }
}