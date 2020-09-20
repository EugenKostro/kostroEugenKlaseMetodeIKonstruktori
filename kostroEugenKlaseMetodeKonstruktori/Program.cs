using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostroEugenKlaseMetodeKonstruktori
{
    class Program
    {
        static void Main(string[] args)
        {
            Proceduralni x = new Proceduralni();
            Objektni y = new Objektni();
            Funkcionalni z = new Funkcionalni();

            Console.WriteLine("Upisite vrijednost za x: ");
            x.Postotak = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisite vrijednost za z: ");
            z.Postotak = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisite vrijednost za y: ");
            y.Postotak = Convert.ToInt32(Console.ReadLine());

            if (x.Postotak + z.Postotak + y.Postotak !=100)
            {
                Console.WriteLine("Neispravan unos podataka!");
            }
            else
            {
                if (x.Postotak > y.Postotak && x.Postotak > z.Postotak)
                {
                    Console.WriteLine("Najvise se koristi Proceduralni!");
                }
                else if (y.Postotak > x.Postotak && y.Postotak > z.Postotak)
                {
                    Console.WriteLine("Najvise se koristi Objektni!");
                }
                else if (z.Postotak > x.Postotak && z.Postotak > y.Postotak)
                {
                    Console.WriteLine("Najvise se koristit Funkcionalni!");
                }
            }


            Console.ReadKey();
        }
    }
}
