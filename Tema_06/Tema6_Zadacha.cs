using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6_Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            do
            {
                N = Convert.ToInt32(Console.ReadLine());
            } while (N < 0 || N % 2 != 0);

            int[] array;
            do
            {
                array = Console.ReadLine()
                    .Split(' ')
                    .Select(x => Convert.ToInt32(x))
                    .ToArray();
            } while (array.Length != N);

            int[] firstHalf = array.Take(N / 2).ToArray();
            int[] secondHalf = array.Skip(N / 2).Take(N / 2).ToArray();

            Console.WriteLine(String.Join(" ", firstHalf.OrderBy(x => x)) + " " +
                String.Join(" ", secondHalf.OrderByDescending(x => x)));
        }
    }
}
