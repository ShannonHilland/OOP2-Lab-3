using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Cat : Animal, IAnimal
    {
        public string Height { get; set; }
        public Cat() { }
        public Cat(string name, string colour, string age)
            : base(name, colour, age) {}
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
        public string Cry()
        {
            return $"Meow!";
        }
    }
}
