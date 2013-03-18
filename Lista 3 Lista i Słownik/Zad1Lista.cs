using System;

namespace ClassLibrary1
{
    public class MojaLista<MyType>
    {
        private MojaListaItem<MyType> first;
        private MojaListaItem<MyType> last;

        public bool IsEmpty { get { return first == null; } }

        /// <summary>
        /// dodanie na początku
        /// </summary>
        /// <param name="item">dodawany element</param>
        public void Insert(MyType item)
        {
            MojaListaItem<MyType> ogniwo = new MojaListaItem<MyType>() { wartosc = item };

            if (first == null)
            {
                first = ogniwo;
                last = ogniwo;
            }

            else
            {
                first.prev = ogniwo;
                ogniwo.next = first;
                first = ogniwo;
            }

        }

        /// <summary>
        /// dodwanie na końcu
        /// </summary>
        /// <param name="item"></param>
        public void Append(MyType item)
        {
            MojaListaItem<MyType> ogniwo = new MojaListaItem<MyType>() { wartosc = item };

            if (last == null)
            {
                first = ogniwo;
                last = ogniwo;
            }
            else
            {
                last.next = ogniwo;
                ogniwo.prev = last;
                last = ogniwo;
            }
        }

        /// <summary>
        /// wywalanie z poczatku
        /// </summary>
        /// <returns>wywalony element</returns>
        public MyType RemoveStart()
        {
            if (IsEmpty)
            {
                throw new Exception("Nie da się usuwać z listy pustej");
            }
            else
            {
                MyType temp = first.wartosc;
                first = first.next;
                //jesli lista jednoelementowa to first.next bylo null 
                if (first == null)
                    last = null;
                else
                    first.prev = null;
                return temp;
            }
        }

        /// <summary>
        /// wywalanie z konca
        /// </summary>
        /// <returns>wywalony element</returns>
        public MyType RemoveEnd()
        {
            if (IsEmpty)
            {
                throw new Exception("Nie da się usuwać z listy pustej");
            }
            else
            {
                MyType temp = last.wartosc;
                last = last.prev;
                if (last == null)
                    first = null;
                else
                    last.next = null;
                return temp;
            }
        }

        public void Drukarka()
        {
            MojaListaItem<MyType> actual = first;
            if (actual == null)
                Console.WriteLine("[]");
            else
                while (actual != null)
                {
                    Console.WriteLine(actual.wartosc);
                    actual = actual.next;
                }
        }

    }

    class MojaListaItem<MyType>
    {
        public MyType wartosc;
        public MojaListaItem<MyType> next;
        public MojaListaItem<MyType> prev;
    }

}
