using ObserverPattern.Observer.Abstract;

namespace ObserverPattern.Observable;

public class WeatherStation : IObservable
{
    private List<IObserver> observers;
    private float temperature;
    public float Temperature
    {
        get { return temperature; }
        set { temperature = value; }
    }

    private float humidity;
    public float Humidity
    {
        get { return humidity; }
        set { humidity = value; }
    }

    private float pressure;
    public float Pressure
    {
        get { return pressure; }
        set { pressure = value; }
    }

    public WeatherStation()
    {
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
        foreach (var observer in observers)
        {
            observer.Update();
        }
    }
    public void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        MeasurementsChanged();
    }
}
