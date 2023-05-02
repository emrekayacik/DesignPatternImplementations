using ObserverPattern.Observable;
using ObserverPattern.Observer.Abstract;
using ObserverPattern.Observer.Interfaces;

namespace ObserverPattern.Observer.Concrete;

internal class TRTDisplayScreen : IDisplay, IObserver
{
    private float temperature;
    private float humidity;
    private WeatherStation weatherStation;
    public TRTDisplayScreen(WeatherStation _weatherStation)
    {
        weatherStation = _weatherStation;
    }
    public void Update()
    {
        this.temperature = weatherStation.Temperature;
        this.humidity = weatherStation.Humidity;
        Display();
    }
    public void Display()
    {
        Console.WriteLine("Displaying on TRT Screen.\nHumidity: {0}\nTemperature: {1}\n", humidity, temperature);
    }
}
