using ObserverPattern.Observable;
using ObserverPattern.Observer.Abstract;
using ObserverPattern.Observer.Interfaces;

namespace ObserverPattern.Observer.Concrete;

public class ForecastDisplayScreen : IDisplay, IObserver
{
    private float pressure;
    private WeatherStation WeatherStation;

    public ForecastDisplayScreen(WeatherStation _weatherStation)
    {
        WeatherStation = _weatherStation;
        WeatherStation.RegisterObserver(this);
    }

    public void Update()
    {
        this.pressure = WeatherStation.Pressure;
        Display();
    }

    public void Display()
    {
        string forecast = "Improving weather on the way!";
        if (pressure <= 29.0f)
        {
            forecast = "Watch out for cooler, rainy weather";
        }
        else if (pressure > 29.0f && pressure <= 30.0f)
        {
            forecast = "More of the same";
        }
        else if (pressure > 30.0f && pressure <= 31.0f)
        {
            forecast = "Nice weather incoming";
        }

        Console.WriteLine("Forecast: " + forecast + "\n");
    }
}
