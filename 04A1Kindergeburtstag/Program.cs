using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04A1Kindergeburtstag
{
    class Program
    {
        static void Main(string[] args)
        {
            int eier, kinder;
            int ek, rest;

            Console.Write("Bitte erfassen Sie die Anzahl der Kinder:");
            kinder = Convert.ToInt16(Console.ReadLine());
            Console.Write("Bitte erfassen Sie die Anzahl der Eier  :");
            eier = Convert.ToInt16(Console.ReadLine());

            ek = eier / kinder;
            rest = eier % kinder;

            Console.WriteLine("Anzahl der Eier je Kind " + ek);
            Console.WriteLine("Anzahl der Resteier     " + rest);


        }
    }
}
