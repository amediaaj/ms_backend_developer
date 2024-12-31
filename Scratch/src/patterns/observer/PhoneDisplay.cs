public class PhoneDisplay : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine("Phone display: Temperature updated to " + temperature + " degrees.");
    }
}