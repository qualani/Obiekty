using System;

namespace Lista3

{
    class Program
    {
        static void Main()
        {
            Bufor<int> bufor1 = new Bufor<int>(3);

            // tworzymy bufor o wielkości 3
            // spróbujemy do niego dodać 4 elementy
            Console.WriteLine(bufor1 + 1);
            bufor1.Drukarka();
            Console.WriteLine(bufor1 + 2);
            bufor1.Drukarka();
            Console.WriteLine(bufor1 + 3);
            bufor1.Drukarka();
            //wyświetli False bo nie doda 4tego elementu
            Console.WriteLine(bufor1 + 4);
            //wyświetli zabrany element a natsępnie zawartość bufora w celu sprawdzenia czy wszystko działa 
            Console.WriteLine("Taken " + bufor1.Take.ToString());            
            bufor1.Drukarka();
            Console.WriteLine(bufor1 + 4);
            bufor1.Drukarka();
            Console.WriteLine();   

            //można odkomentować żeby sprawdzić czy działa wyjątek
           // Bufor<int> bufor2 = new Bufor<int>(1);
           //Console.WriteLine("Taken " + bufor2.Take.ToString());

            //pierwsze zadanie
            Zbior zbior = new Zbior();
            for (int i = 0; i < 20; i++) zbior.Wstaw(i);
            for (int i = 0; i < 20; i++) zbior.Wstaw(i);
            Console.WriteLine(zbior.Tablica[12]);
            Console.WriteLine(zbior.Tablica[22]);

            Console.WriteLine(); // Pusta linia

            Torba torba = new Torba();
            for (int i = 1; i < 10; i++) torba.Wstaw(i);
            for (int i = 1; i < 10; i++) torba.Wstaw(i);
            foreach (int elem in torba)
                Console.WriteLine(elem);

            Console.ReadLine();
        }
    }
}
