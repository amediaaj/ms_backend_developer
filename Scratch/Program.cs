using System.IO.Pipes;

class Program
{
    static void Main ()
    {
       TestAnimal();
    }

    static void TestAnimal()
    {
        Animal animal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        List<Animal> animalList = new List<Animal>();
        animalList.Add(animal);
        animalList.Add(dog);
        animalList.Add(cat);

        foreach(Animal item in animalList)
        {

            Type type = item.GetType();
            if(type == typeof(Animal))
            {
                item.MakeSound();
                item.Eat();
            }else if(type == typeof(Dog))
            {
                Dog item_dog  = (Dog)item;
                item_dog.MakeSound();
                item_dog.Eat();
            }else if(type == typeof(Cat))
            {
                Cat item_cat = (Cat)item;
                item_cat.MakeSound();
                item_cat.Eat();
            }
        }
    }
}