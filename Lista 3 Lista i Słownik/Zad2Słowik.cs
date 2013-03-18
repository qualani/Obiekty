using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Zad2Słownik<K, V>
    {

        Para<K, V> first;

        public void Add(K key, V val)
        {
            //jesli klucz ktory chcemy dodac juz istnieje
            V dummy;
            if (Search(key, out dummy))
            {
                throw new ArgumentException("Istnieje już taki klucz jaki chcesz dodać");
            }

            //tworzymy ogniwo ktore chcemy dodac
            Para<K, V> ogniwo = new Para<K, V>() { val = val, key = key };

            if (first == null)
            {
                first = ogniwo;
            }

            else
            {
                ogniwo.next = first;
                first = ogniwo;
            }
        }


        public bool Search(K key, out V val)
        {
            Para<K, V> actual = first;
            // przejdz po kazdym i sprawdz GetHashCode bo nie znamy typu dokladnie
            while (actual != null)
            {
                if (actual.key.GetHashCode() == key.GetHashCode())
                {
                    val = actual.val;
                    return true;
                }
                actual = actual.next;
            }
            //  nieznamy typu stad default (null nie moze byc)
            val = default(V);
            return false;
        }

        public bool Remove(K key)
        {
            //jak przy wbudowanym removie, zwraca true jesli ten element zostal usuniety
            Para<K, V> actual = first, actprev = null;
            while (actual != null)
            {
                if (actual.key.GetHashCode() == key.GetHashCode())
                {
                    //jesli nie jestesmy pierwszym elementem i go usuwamy
                    if (actprev != null)
                        actprev.next = actual.next;
                    // jesli jestesmy pierszym elementem
                    else
                        first = actual.next;
                    return true;

                }
                actprev = actual;
                actual = actual.next;
            }
            return false;
        }

        public void Drukarka()
        {
            Para<K, V> actual = first;
            if (actual == null)
                Console.WriteLine("[]");
            else
                while (actual != null)
                {
                    Console.WriteLine(actual.key.ToString() + " " + actual.val.ToString());
                    actual = actual.next;
                }
        }
    }

    public class Para<K, V>
    {
        public K key;
        public V val;
        public Para<K, V> next;
    }

}

