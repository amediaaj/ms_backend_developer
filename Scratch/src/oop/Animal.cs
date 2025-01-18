public class Animal : IAnimal 
{
    public Animal()
    {

    }

    public void Eat()
    {
        Console.WriteLine("This animal is eating.");
    }

    public virtual void MakeSound(){
        Console.WriteLine("This animal is making a sound.");
    }
}