using DesignPatterns.ChapterTwo.StarBuzz.Beverages.Base;

namespace DesignPatterns.ChapterTwo.StarBuzz.Beverages;

public class Espresso : Beverage
{
    public Espresso()
    {
        Description = "Espresso";
    }
    
    public override double Cost()
    {
        return 1.99;
    }
}