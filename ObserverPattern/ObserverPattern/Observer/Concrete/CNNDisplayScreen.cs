using ObserverPattern.Observable;
using ObserverPattern.Observer.Abstract;
using ObserverPattern.Observer.Interfaces;

namespace ObserverPattern.Observer.Concrete;

internal class CNNDisplayScreen : IDisplay, IObserver
{
    private float temperature;
    private float humidity;
    private float pressure;
    private WeatherStation weatherStation;
    public CNNDisplayScreen(WeatherStation _weatherStation)
    {
        this.weatherStation = _weatherStation;
    }
    public void Update()
    {
        this.temperature = weatherStation.Temperature;
        this.humidity = weatherStation.Humidity;
        this.pressure = weatherStation.Pressure;
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Displaying on CNN Screen.\nHumidity: {0}\nTemperature: {1}\nPressure:{2}\n", humidity, temperature, pressure);
    }
}
