public class Dog : Animal, IAnimal
{
    public Dog()
    {

    }

    public override void MakeSound()
    {
        Console.WriteLine("This Dog is making a sound - WOOF!");
    }

    public new void Eat()
    {
        Console.WriteLine("This dog is eating - MILKBONES!");
    }
}