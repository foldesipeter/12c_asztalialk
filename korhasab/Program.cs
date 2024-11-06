using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korhasab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.objektum
            // A kör osztály felhasználása
            // 1. objektum

            kor K1 = new kor(); // Objektum példány létrehozása üresen
            K1.ReadSugar(15.0); // Sugár megadása 
            K1.SetKerulet();
            K1.SetTerulet();
            Console.WriteLine($"{K1.GetSugar()} sugarú kör terüete {K1.GetKerulet()},területe: {K1.GetTerulet()}");

            #endregion EOP 1.objektum
            #region 2.objektum
            kor K2 = new kor(28.7); // Objektum példány létrehozása üresen
            K2.ReadSugar(15.0); // Sugár megadása 
            K2.SetKerulet();    //Kerület kiszámítása
            K2.SetTerulet();    //Terület kiszámítása 
            Console.WriteLine($"{K2.GetSugar()} sugarú kör terüete {K2.GetKerulet()},területe: {K2.GetTerulet()}");

            Console.ReadKey();
            #endregion EOP 2.objektum
            #region kor2 használata
            kor2 k21 = new kor2(24.5);
            Console.WriteLine($"A kör adatai: \nsugar= {k21.GetSugar()}, \nkerulet = {k21.GetKerulet()}, \nterulet = {k21.GetTerulet()}");

            #endregion Eof kor2
            Console.ReadKey();
        }
    }
}
