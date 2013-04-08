using System;

namespace Lista3
{
    public class Bufor<T>
    {
        // bufor to lista , _freepos to pozycja następnego wolnego miejsca w buforze, 
        //_outpos to pozycja z ktorej bedziemy wyrzucac element
        // counter i wielkość to zwykłe zmienne do kontrolowania wielkości bufora
        private T [] _bufor;
        private int _freePos = 0, _outPos = 0, counter=0;
        int _wielkosc;
        
        //konstruktor
        public Bufor(int wielkosc)
        {
            this._wielkosc = wielkosc;
            _bufor = new T[wielkosc];
        }

        //przeładowanie operatora
        public static bool operator +(Bufor<T> buff, T el)
        {
            if (buff.counter == buff._wielkosc)
            {
                return false;
            }
            else
            {
                buff._bufor[buff._freePos] = el;
                buff._freePos = ++buff._freePos % buff._wielkosc;
                buff.counter++;
                return true;
            }
        }

        //pobieranie zaprogramowane jako właściwość
        public T Take
        {
            get 
            {
                if (counter == 0) { throw new Exception("Bufor jest pusty"); }
                else 
                {
                    int old = _outPos;
                    _outPos = ++_outPos % _wielkosc;
                    counter--;
                    return _bufor[old];
                    
                }
            }
        }

        // drukarka do drukowania całego bufora
        public void Drukarka()
        {
            if (counter == 0)
                Console.WriteLine("[]");
            else
            {
                int temp = _outPos;
                for (int i = 0; i < counter; i++)
                    Console.WriteLine(_bufor[(i + temp) % _wielkosc]);
            }
        }

    }
}

