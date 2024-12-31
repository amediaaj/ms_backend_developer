public class DesktopDisplay : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine("Desktop display: Temperature updated to " + temperature + " degrees.");
    }
}