using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpitni_Materiali_Temi
{
    class Program
    {
        static void Main(string[] args)
        {
            long n;
            do
            {
                n = Convert.ToInt64(Console.ReadLine());
            } while (n < 1 || n > 600000);

            for (int a = 1; a < 10; a++)
                for (int b = 1; b < 10; b++)
                    for (int c = 1; c < 10; c++)
                        for (int d = 1; d < 10; d++)
                            if ((n % a == 0) && (n % b == 0) && (n % c == 0) && (n % d == 0))
                                Console.Write("{0}{1}{2}{3} ", a, b, c, d);

            Console.ReadKey(true);
        }
    }
}
