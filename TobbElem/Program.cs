using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Írjunk olyan programot, amely addig kér
be egész számokat a billentyűzetről, amíg azok összege meg nem haladja a 100-at. A
beolvasás végén írjuk ki azt, hogy a bekért számok közül hány volt páros, és hány volt
páratlan.*/

namespace TobbElem
{
    class TobbElemOsztaly
    {
        // Osztályváltozók
        private int szam;
        private bool isParos;
        // Konstuktor
        public TobbElemOsztaly()
        {
            szam = 0;
            isParos = false;
        }

        public void GetSzam(int p)
        {
            szam = p;
        }
        public void SetSzamTipus()
        {
            isParos = szam % 2 == 0;
        }
        public bool outSzamTipus()
        {
            return isParos;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string valasz = string.Empty;
            // Példányosíjuk az osztályt, másnéven objektumot hozunk létre az osztályból
            TobbElemOsztaly a = new TobbElemOsztaly();

            // Szám megadása
            a.GetSzam(15);
            a.SetSzamTipus();
            valasz = a.outSzamTipus() ? "páros" : "páratlan";
            Console.WriteLine($"A szám típusa: {valasz}");
            Console.ReadKey();

        }
    }
}
