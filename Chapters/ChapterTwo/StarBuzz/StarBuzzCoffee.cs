using DesignPatterns.ChapterTwo.StarBuzz.Beverages;
using DesignPatterns.ChapterTwo.StarBuzz.Beverages.Base;
using DesignPatterns.ChapterTwo.StarBuzz.Condiments;

namespace DesignPatterns.ChapterTwo.StarBuzz;

public class StarBuzzCoffee
{
    public void Run()
    {
        Beverage espresso = new Espresso();
        Console.WriteLine(espresso.GetDescription(), espresso.Cost());
        
        Beverage darkRoast = new DarkRoast();
        darkRoast.SetSize(Beverage.Size.Venti);
        darkRoast = new Mocha(darkRoast);
        darkRoast = new Mocha(darkRoast);
        darkRoast = new Whip(darkRoast);
        Console.WriteLine($"{darkRoast.GetDescription()} {darkRoast.Cost()}");
        
        Beverage houseBlend = new HouseBlend();
        houseBlend.SetSize(Beverage.Size.Grande);
        houseBlend = new Soy(houseBlend);
        houseBlend = new Mocha(houseBlend);
        houseBlend = new Whip(houseBlend);
        Console.WriteLine($"{houseBlend.GetDescription()} {houseBlend.Cost()}");
    }
}