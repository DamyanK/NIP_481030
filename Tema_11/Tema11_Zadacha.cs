using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tema11_Zadacha
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTime Expirity { get; set; }
    }

    //nuget.org
    class Program
    {
        static void Main(string[] args)
        {
            // part 1
            List<Product> list1 = new List<Product>();
            list1.Add(new Product()
            {
                ID = 1,
                Name = "Beer",
                Price = 1.2m,
                Stock = 5,
                Expirity = new DateTime(2020, 03, 31)
            });
            list1.Add(new Product()
            {
                ID = 2,
                Name = "Fries",
                Price = 2.4m,
                Stock = 10,
                Expirity = new DateTime(2020, 03, 31)
            });
            var json1 = JsonConvert.SerializeObject(list1);
            Console.WriteLine(json1);
            // part 2
            var list2 = JsonConvert.DeserializeObject<List<Product>>(json1);
            foreach (var item in list2) Console.WriteLine(item.Name);
        }
    }
}
