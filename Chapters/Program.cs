using DesignPatterns.ChapterOne.SimUDuck;
using DesignPatterns.ChapterOne.WeatherApp;
using DesignPatterns.ChapterTwo.StarBuzz;
using DesignPatterns.FactoryPattern;

Console.WriteLine("\n---Duck Simulator---\n");
MiniDucksSimulator miniDucksSimulator = new MiniDucksSimulator();
miniDucksSimulator.Run();

Console.WriteLine("\n---Weather Station---\n");
WeatherStation weatherStation = new WeatherStation();
weatherStation.Run();

Console.WriteLine("\n---StarBuzz Coffee---\n");
StarBuzzCoffee starBuzzCoffee = new StarBuzzCoffee();
starBuzzCoffee.Run();

Console.WriteLine("\n---Pizza Store---\n");
PizzaTestDrive pizzaTestDrive = new PizzaTestDrive();
pizzaTestDrive.Run();