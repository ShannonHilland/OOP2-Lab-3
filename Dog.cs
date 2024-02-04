using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Dog : Animal, IAnimal
    {
        public string Height { get; set; }
        public Dog() { }
        public Dog(string name, string colour, string age)
            : base(name, colour, age){}
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
        public string Cry()
        {
            return "Woof!";
        }
    }
}
