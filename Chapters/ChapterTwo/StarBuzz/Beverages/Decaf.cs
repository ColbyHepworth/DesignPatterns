using DesignPatterns.ChapterTwo.StarBuzz.Beverages.Base;

namespace DesignPatterns.ChapterTwo.StarBuzz.Beverages;

public class Decaf : Beverage
{
    public Decaf()
    {
        Description = "Decaf Coffee";
    }
    
    public override double Cost()
    {
        return 1.05;
    }
}