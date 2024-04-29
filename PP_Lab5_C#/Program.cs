class Program
{
    static void Main()
    {
        Dog dog = new Dog("будка", 16);

        Cat cat = new Cat("дом", "сибирская");

        Horse horse = new Horse("конюшня", "белая");

        Vet vet = new Vet();

        dog.makeNoise();
        cat.eat();
        vet.treatAnimal(horse);
    }
}


class Animal
{
    public int food = 0;
    public string location;

    public Animal(string location)
    {
        this.location = location;
    }

    public virtual void makeNoise()
    {
        Console.WriteLine("Животное издает звук");
    }

    public virtual void eat()
    {
        Console.WriteLine("Животное поело");
        food += 10;
    }
}

class Dog : Animal
{
    public int size;
    public Dog(string location, int size) : base(location) 
    {
        this.size = size; 
    }
    public override void makeNoise()
    {
        Console.WriteLine("Гавкает");
    }

    public override void eat()
    {
        Console.WriteLine("Собака ест");
        food += 10;
    }
}

class Cat : Animal
{
    public string breead;
    public Cat(string location, string breead) : base(location)
    {
        this.breead = breead;
    }
    public override void makeNoise()
    {
        Console.WriteLine("Орёт");
    }

    public override void eat()
    {
        Console.WriteLine("Кошка ест");
        food += 10;
    }
}

class Horse: Animal
{
    public string color;
    public Horse(string location, string color) : base(location)
    {
        this.color = color;
    }
    public override void makeNoise()
    {
        Console.WriteLine("Ржёт");
    }

    public override void eat()
    {
        Console.WriteLine("Лошадь ест");
        food += 10;
    }
}

class Vet
{
    public void treatAnimal(Animal animal)
    {
        Console.WriteLine($"голод: {animal.food}, локация: {animal.location}");
    }
}