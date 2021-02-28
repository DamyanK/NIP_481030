using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4_Zadacha
{
    class Robot
    {
        public string Model { get; set; }
        public string ID { get; set; }

        public Robot(string model, string id)
        {
            this.Model = model;
            this.ID = id;
        }
    }

    class Citizen
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string ID { get; set; }
        
        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Robot> robots = new List<Robot>();
            List<Citizen> citizens = new List<Citizen>();

            var line = Console.ReadLine().Split().ToArray();
            while (line.Count() > 1)
            {
                if (line.Count() == 2) robots.Add(new Robot(line[0], line[1]));
                else citizens.Add(new Citizen(line[0], Convert.ToInt32(line[1]), line[2]));
                line = Console.ReadLine().Split().ToArray();
            }

            string searching = Console.ReadLine();
            Console.WriteLine(string.Join("\n", robots.Select(x => x.ID).ToArray().Where(x
            => x.Substring(x.Length - 3, 3) == searching).ToArray()));
            Console.WriteLine(string.Join("\n", citizens.Select(x =>
            x.ID).ToArray().Where(x => x.Substring(x.Length - 3, 3) == searching).ToArray()));
        }
    }
}
