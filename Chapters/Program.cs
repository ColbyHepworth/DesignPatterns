using DesignPatterns.ChapterOne.SimUDuck;
using DesignPatterns.ChapterOne.WeatherApp;

MiniDucksSimulator miniDucksSimulator = new MiniDucksSimulator();
miniDucksSimulator.Run();

WeatherStation weatherStation = new WeatherStation();
weatherStation.Run();