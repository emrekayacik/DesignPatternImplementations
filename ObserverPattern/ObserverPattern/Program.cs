
using ObserverPattern.Observable;
using ObserverPattern.Observer.Abstract;
using ObserverPattern.Observer.Concrete;

WeatherStation weatherStation = new WeatherStation();

IObserver CNN = new CNNDisplayScreen(weatherStation);
IObserver TRT = new TRTDisplayScreen(weatherStation);
IObserver Forecast = new ForecastDisplayScreen(weatherStation);

weatherStation.RegisterObserver(CNN);
weatherStation.RegisterObserver(TRT);
//weatherStation.RegisterObserver(Forecast);

weatherStation.SetMeasurements(30.0f, 36.4f, 6.4f);

weatherStation.RemoveObserver(TRT);

weatherStation.SetMeasurements(1.0f, 2.4f, 32.4f);

Console.ReadKey();
