using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        enum Animals{ Cat, Dog, Tiger, Wolf };
        static void Main(string[] args)
        {
            Animals b = Animals.Wolf;
            Animals c = Animals.Cat;

            if (b == Animals.Wolf)
            {
                Console.WriteLine("A b állat a farkas");
            }
            if (c == Animals.Cat)
            {
                Console.WriteLine("A c állat macska");
            }


            Console.ReadKey();
        }
    }
}
