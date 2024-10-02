using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palackok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Palack palack1 = new Palack("Narancslé", 500, 300);
            Palack palack2 = new Palack("Almalé", 500, 200);
            Console.WriteLine(palack1.ToString());
            Console.WriteLine(palack2.ToString());

            palack1.HozzaOnt(palack2);
            Console.WriteLine(palack1.ToString());

            VisszavalthatoPalack visszavalthatoPalack1 = new VisszavalthatoPalack("Narancslé", 500, 300, 50);
            VisszavalthatoPalack visszavalthatoPalack2 = new VisszavalthatoPalack("Almalé", 500, 200);
            Console.WriteLine(visszavalthatoPalack1.ToString());
            Console.WriteLine(visszavalthatoPalack2.ToString());

            Rekesz rekesz = new Rekesz(2000);
            rekesz.UjPalack(palack1);
            rekesz.UjPalack(visszavalthatoPalack1);
            rekesz.UjPalack(visszavalthatoPalack2);

            Console.WriteLine($"Rekesz súlya: {rekesz.Suly()}");
            Console.WriteLine($"Rekesz összes pénz: {rekesz.OsszesPenz()}");

            Palack palack3 = new Palack("Víz", 1000, 1000);
            rekesz.UjPalack(palack3);
            Console.WriteLine($"Rekesz súlya (túlterhelés után): {rekesz.Suly()}");
            Console.WriteLine($"Rekesz összes pénz (túlterhelés után): {rekesz.OsszesPenz()}");
        }
    }
}
