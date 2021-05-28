using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(x => Convert.ToInt32(x))
                .ToList();

            while (true)
            {
                List<string> curent = Console.ReadLine()
                    .Split(' ')
                    .ToList();

                if (curent[0] == "print")
                {
                    Console.WriteLine("[{0}]", string.Join(", ", input));
                    break;
                }
                if (curent[0] == "add")
                {
                    int index = Convert.ToInt32(curent[1]);
                    int element = Convert.ToInt32(curent[2]);

                    int[] temp = new int[input.Count + 1];
                    for (int i = 0; i < input.Count; i++)
                    {
                        temp[i] = input[i];
                    }

                    for (int i = temp.Length - 1; i >= index; i--)
                    {
                        temp[i] = temp[i - 1];
                    }
                    temp[index] = element;

                    input = temp.ToList();
                }
                if (curent[0] == "addMany")
                {
                    int[] items = new int[curent.Count - 2];
                    for (int i = 0; i < items.Length; i++)
                    {
                        items[i] = Convert.ToInt32(curent[i + 2]);
                    }

                    int index = Convert.ToInt32(curent[1]);

                    int[] temp = new int[input.Count + items.Length];
                    
                    for (int i = 0; i < index; i++)
                    {
                        temp[i] = input[i];
                    }

                    for (int i = 0; i < items.Length; i++)
                    {
                        temp[index + i] = items[i];
                    }

                    for (int i = items.Length; i < temp.Length; i++)
                    {
                        temp[i] = input[i - items.Length];
                    }

                    input = temp.ToList();
                }
                if (curent[0] == "contains")
                {
                    int searchedNumber = Convert.ToInt32(curent[1]);
                    int index = -1;

                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] == searchedNumber)
                        {
                            index = i;
                        }
                    }

                    Console.WriteLine(index);
                }
                if (curent[0] == "remove")
                {
                    int index = Convert.ToInt32(curent[1]);
                    input.RemoveAt(index);
                }
                if (curent[0] == "shift")
                {
                    int shiftValue = Convert.ToInt32(curent[1]);

                    var first = new List<int>();
                    var second = new List<int>();

                    for (int i = 0; i < shiftValue; i++)
                    {
                        first.Add(input[i]);
                    }
                    for (int i = shiftValue; i < input.Count; i++)
                    {
                        second.Add(input[i]);
                    }

                    input.Clear();

                    for (int i = 0; i < second.Count; i++)
                    {
                        input.Add(second[i]);
                    }
                    for (int i = 0; i < first.Count; i++)
                    {
                        input.Add(first[i]);
                    }
                }
                if (curent[0] == "sumPairs")
                {
                    List<int> temp = new List<int>();

                    if (input.Count % 2 == 0)
                    {
                        for (int i = 0; i < input.Count - 1; i += 2)
                        {
                            temp.Add(input[i] + input[i + 1]);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < input.Count - 1; i += 2)
                        {
                            temp.Add(input[i] + input[i + 1]);
                        }
                        temp.Add(input[input.Count - 1]);
                    }
                    input = temp;
                }
            }
        }
    }
}
