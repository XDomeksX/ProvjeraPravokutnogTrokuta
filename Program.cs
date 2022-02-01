using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvjeraPravokutnogTrokuta
{
    internal class Trokut
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;

            Console.WriteLine("Unesi stranicu a: ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x <= 1)
            {
                Console.WriteLine("Stranica nemože biti 0 i manje!");
                x = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Unesi stranicu b: ");
            y = Convert.ToInt32(Console.ReadLine());
            if (y <= 1)
            {
                Console.WriteLine("Stranica nemože biti 0 i manje!");
                y = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Unesi stranicu c: ");
            z = Convert.ToInt32(Console.ReadLine());
            if (z <= 1)
            {
                Console.WriteLine("Stranica nemože biti 0 i manje!");
                z = Convert.ToInt32(Console.ReadLine());
            }


            if (x*x + y*y == z * z)
            {
                Console.WriteLine("Ovo je pravokutni trokut.");
            }
            else if(x * x + y * y != z * z)
            {
                Console.WriteLine("Ovo nije pravokutni trokut.");
            }

            Console.ReadKey();
        }
    }
}
