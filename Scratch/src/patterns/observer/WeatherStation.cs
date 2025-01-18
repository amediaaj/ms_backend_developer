public class WeatherStation
{
    private List<IObserver> observers;
    private float temperature;

    public WeatherStation(){
        observers = new List<IObserver>();
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach(var observer in observers)
        {
            observer.Update(temperature);
        }
    }

    public void SetTemperature(float newTemperature)
    {
        temperature = newTemperature;
        NotifyObservers();
    }
}