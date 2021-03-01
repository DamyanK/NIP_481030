using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema5_Zadacha
{
    class Program
    {
        static Fridge fridge = new Fridge();
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            while (line != "END")
            {
                string[] cmdArgs = line.Split(' ');
                switch (cmdArgs[0])
                {
                    case "Add":
                        Console.ForegroundColor = ConsoleColor.Red;
                        fridge.AddProduct(cmdArgs[1]);
                        break;
                    case "Check":
                        Console.ForegroundColor = ConsoleColor.Red;
                        if (fridge.CheckProductIsInStock(cmdArgs[1]))
                        {
                            Console.WriteLine("Product {0} is in stock.", cmdArgs[1]);
                        }
                        else
                        {
                            Console.WriteLine("Not in stock");
                        }
                        break;
                    case "Remove":
                        Console.ForegroundColor = ConsoleColor.Red;
                        try
                        {
                            int index = int.Parse(cmdArgs[1]);
                            Console.WriteLine(fridge.RemoveProductByIndex(index));
                        }
                        catch (FormatException e)
                        {
                            if (e.Data != null)
                            {
                                Console.WriteLine(fridge.RemoveProductByName(cmdArgs[1]));
                            }
                        }
                        break;
                    case "Print":
                        Console.ForegroundColor = ConsoleColor.Red;
                        string[] prods = fridge.ProvideInformationAboutAllProducts();
                        foreach (var item in prods)
                        {
                            if (item != null)
                            {
                                Console.WriteLine("Product {0}", item);
                            }
                        }
                        break;
                    case "Cook":
                        Console.ForegroundColor = ConsoleColor.Red;
                        int start = Convert.ToInt32(cmdArgs[1]);
                        int end = Convert.ToInt32(cmdArgs[2]);

                        if (start < 0)
                        {
                            start = 0;
                        }
                        if (end > fridge.GetLength())
                        {
                            end = fridge.GetLength();
                        }

                        string[] cooked = fridge.CookMeal(start, end);
                        Console.WriteLine("Meal cooked. Used Products: " + String.Join(", ", cooked));
                        break;
                }
                Console.ForegroundColor = ConsoleColor.White;
                line = Console.ReadLine();
            }
        }
    }
}
