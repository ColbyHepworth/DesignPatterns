namespace DesignPatterns.ChapterOne.WeatherApp.Interfaces;

public interface ISubject
{
    public void RegisterObserver(IObserver observer);
    public void RemoveObserver(IObserver observer);
    public void NotifyObservers();
}