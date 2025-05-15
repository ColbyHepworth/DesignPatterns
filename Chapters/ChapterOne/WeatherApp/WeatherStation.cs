using DesignPatterns.ChapterOne.WeatherApp.DisplayElements;

namespace DesignPatterns.ChapterOne.WeatherApp;

public class WeatherStation
{
    public void Run()
    {
        WeatherData weatherData = new WeatherData();
        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
        
        weatherData.SetMeasurements(80, 65, 30.4f);
        weatherData.SetMeasurements(82, 70, 29.2f);
        weatherData.SetMeasurements(78, 90, 29.2f);
    }
}