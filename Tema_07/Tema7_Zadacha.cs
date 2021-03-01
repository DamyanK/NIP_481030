using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            int count = 0;
            int[] notes = { 1, 5, 10, 20, 100 };

            for (int i = notes.Length - 1; i >= 0; i--)
            {
                if (amount >= notes[i] && amount != 0)
                {
                    count += amount / notes[i];
                    amount %= notes[i];
                }
            }

            Console.WriteLine(count);
        }
    }
}
