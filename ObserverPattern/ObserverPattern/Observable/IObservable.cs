using ObserverPattern.Observer.Abstract;

namespace ObserverPattern.Observable;

public interface IObservable // ISubject
{
    public void RegisterObserver(IObserver observer);
    public void RemoveObserver(IObserver observer);
    public void NotifyObservers();
}
