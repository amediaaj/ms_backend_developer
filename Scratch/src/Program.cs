using Patterns;

class Program
{
    static void Main ()
    {
       // Executes inheritance and polymorphism examples
       TestAnimal();
       // Executes singleton pattern example
       TestDatabase();
       // Executes factory pattern example
       TestNotification();
       // Executes observer pattern example
       TestWeatherStation();
    }

    // Executes observer pattern example
    static void TestWeatherStation()
    {
        Console.WriteLine("***** Testing observer pattern: \n");

        WeatherStation weatherStation = new WeatherStation();
        PhoneDisplay phoneDisplay = new PhoneDisplay();
        DesktopDisplay desktopDisplay = new DesktopDisplay();

        weatherStation.RegisterObserver(phoneDisplay);
        weatherStation.RegisterObserver(desktopDisplay);

        weatherStation.SetTemperature(25.0f);
        weatherStation.SetTemperature(32.0f);

        Console.WriteLine();

    }
    // Executes factory pattern example
    static void TestNotification()
    {
        Console.WriteLine("***** Testing factory pattern: \n");

        NotificationFactory factory = new NotificationFactory();
        INotification email = factory.CreateNotification(Channel.Email);
        email.Send("My Email");

        INotification sms = factory.CreateNotification(Channel.SMS);
        sms.Send("My SMS");

        Console.WriteLine();
    }

    // Executes singleton pattern example
    static void TestDatabase()
    {
        Console.WriteLine("***** Testing singleton pattern: \n");
        Database database = Database.GetInstance();
        Console.WriteLine();
    }

    // Executes inheritance and polymorphism examples
    static void TestAnimal()
    {
        Console.WriteLine("***** Testing inheritance and polymorphism examples: \n");
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
        Console.WriteLine();
    }
}