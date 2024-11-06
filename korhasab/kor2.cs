using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korhasab
{
    class kor2
    {
        // Osztályváltozók
        private double sugar,
            kerulet,
            terulet;
        // konstruktorok
        public kor2() { }
        public kor2(double r)
        {
            this.sugar = r;
            szamitasok();

        }
        // metódusok
        public void SetSugár(double r)
        {
            this.sugar = r;
        }
        public void kalkKerulet()
        {
            this.kerulet = 2 * sugar * Math.PI;
        }
        private double kalkTerulet(double r)
        {
            return Math.Pow(r, 2) * Math.PI;
        }
        private void szamitasok()
        {
            kalkKerulet();
            this.terulet = kalkTerulet(this.sugar);
        }


        public double GetKerulet()
        {
           return this.kerulet;
        }
        public double GetTerulet()
        {
           return this.terulet;
        }
        public double GetSugar()
        {
            return this.sugar;
        }
    }
}
