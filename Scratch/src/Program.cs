﻿using System.Runtime.CompilerServices;
using System.Xml.XPath;
using Pastel;
using Patterns;

class Program
{
    static void Main ()
    // static async Task Main ()
    {
        // Test Person class
        TestPerson();
        // Executes inheritance and polymorphism examples
        TestAnimal();
        // Executes singleton pattern example
        TestDatabase();
        // Executes factory pattern example
        TestNotification();
        // Executes observer pattern example
        TestWeatherStation();
        // Executes async methods
        TestAsync();
        // Executes ThirdpartyService threading example
        TestThirdPartyService();
    }

    // Executes ThirdpartyService threading example
    static void TestThirdPartyService()
    {
        Console.WriteLine("***** Testing ThirdPartyService class: \n");

        ThirdPartyService thirdPartyService = new ThirdPartyService();
        thirdPartyService.FetchDataUsingAsyncAwait();
        Console.WriteLine("I am not blocked by the async method");

        List<Thread> threads = thirdPartyService.FetchReturnThreads();
        Console.WriteLine("I am not blocked by the thread method");
        foreach(Thread thread in threads)
        {
            // Joining results in blocking the main thread
            thread.Join();
        }   

        thirdPartyService.FetchDataUsingThreads();
        Console.WriteLine("I am blocked by the thread method".Pastel("#FF0000"));
        Console.WriteLine();
    }

    // Executes async methods example
    static void TestAsync()
    // static async Task TestAsync()
    {
        Console.WriteLine("***** Testing async methods: \n");

        SimulateAsync simulateAsync = new SimulateAsync();
        ReadFile readFile = new ReadFile();
        Task<string> task1 = simulateAsync.GetInfoAsync();
        Task<string> task2 = simulateAsync.GetInfoAsync("Info from async method with parameter");
        Task<string> task3 = simulateAsync.GetInfoAsync("Info from async method with parameter and delay", 1000);
        Task<string> task4 = readFile.ReadFileAsync("../../../src/async/test.txt");
        // Task<string> task4 = readFile.ReadFileAsync("src/async/test.txt");

          var tasks = new List<Task<string>>
        {
            task1,
            task2,
            task3,
            task4 
        };

        // Print results as they complete
        // Must change method signitures for TestAsync and Main to async Task
        
        // while (tasks.Any())
        // {
        //     var finishedTask = await Task.WhenAny(tasks);
        //     tasks.Remove(finishedTask);

        //     var result = await finishedTask;
        //     Console.WriteLine(result);
        // }

        Task.WhenAll(tasks);
        Console.WriteLine(task1.Result);
        Console.WriteLine(task2.Result);
        Console.WriteLine(task3.Result);
        Console.WriteLine(task4.Result);

        // Calling the static asynchronous method - See definition below
        Task.Run(async () => await PerformLongOperationAsync()).Wait();
        Console.WriteLine("Main method completed.");

        Console.WriteLine();
    }

    public static async Task PerformLongOperationAsync()
    {
        Console.WriteLine("Operation started...");
        await Task.Delay(3000); // Simulate a delay of 3 seconds
        Console.WriteLine("Operation completed.");
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

    static void TestPerson()
    {
        Console.WriteLine("***** Testing Person class: \n");

        Person person = new Person("John", 25);
        person.DisplayInfo();

        person.Name = "Jane";
        person.Age = 30;
        person.DisplayInfo();

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