namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            Console.WriteLine("Please enter a dog name");
            string dogName = Console.ReadLine();
            Console.WriteLine("Please enter a dog colour");
            string dogColour = Console.ReadLine();
            Console.WriteLine("Please enter a dog age in years");
            string dogAge = Console.ReadLine();
            //create dog object
            Dog dog = new Dog(dogName, dogColour, dogAge);
            Console.WriteLine($"The dog's name is {dog.Name}. It is {dog.Colour} and {dog.Age} years old.");
            dog.Eat();
            Console.WriteLine("Please enter a cat name");
            string catName = Console.ReadLine();
            Console.WriteLine("Please enter a cat colour");
            string catColour = Console.ReadLine();
            Console.WriteLine("Please enter a cat age in years");
            string catAge = Console.ReadLine();
            //create cat object
            Cat cat = new Cat(catName, catColour, catAge);
            Console.WriteLine($"The cat's name is {cat.Name}. It is {cat.Colour} and {cat.Age} years old.");
            cat.Eat();
            //Part 2
            Console.WriteLine("Enter a new dog name");
            dogName = Console.ReadLine();
            Console.WriteLine("Enter a new dog colour");
            dogColour = Console.ReadLine();
            Console.WriteLine("Enter a new dog age");
            dogAge = Console.ReadLine();
            Console.WriteLine("Enter a new dog height");
            string dogHeight = Console.ReadLine();
            Dog dog2 = new Dog(dogName, dogColour, dogAge);
            dog2.Height = dogHeight;
            Console.WriteLine($"Dog name: {dog2.Name}\nDog Colour: {dog2.Colour}\nDog Age: {dog2.Age}\nDog Height: {dog2.Height}");
            dog2.Eat();
            Console.WriteLine(dog2.Cry());
            Console.WriteLine("Enter a new cat name");
            catName = Console.ReadLine();
            Console.WriteLine("Enter a new cat colour");
            catColour = Console.ReadLine();
            Console.WriteLine("Enter a new cat age");
            catAge = Console.ReadLine();
            Console.WriteLine("Enter a new cat height");
            string catHeight = Console.ReadLine();
            Cat cat2 = new Cat(catName, catColour, catAge);
            cat2.Height = catHeight;
            Console.WriteLine($"Cat name: {cat2.Name}\nCat Colour: {cat2.Colour}\nCat Age: {cat2.Age}\nCat Height: {cat2.Height}");
            cat2.Eat();
            Console.WriteLine(cat2.Cry());
            //Create Animal List
            List<Animal> animals = new List<Animal>();
            animals.Add(dog);
            animals.Add(cat);
            animals.Add(dog2);
            animals.Add(cat2);
            Console.WriteLine("Names of the animals in the list 'Animals':");
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }


        }
    }
}
