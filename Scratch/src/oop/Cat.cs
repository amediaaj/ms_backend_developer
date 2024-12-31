public class Cat : Animal
{
    public Cat()
    {

    }

    public override void MakeSound()
    {
        Console.WriteLine("This Cat is making a sound - MEOW!");
    }

        public new void Eat()
    {
        Console.WriteLine("This cat is eating - CANNED TUNA!");
    }
}