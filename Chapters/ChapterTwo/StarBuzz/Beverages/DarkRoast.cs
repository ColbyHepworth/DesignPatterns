using DesignPatterns.ChapterTwo.StarBuzz.Beverages.Base;

namespace DesignPatterns.ChapterTwo.StarBuzz.Beverages;

public class DarkRoast : Beverage
{
    public DarkRoast()
    {
        Description = "Dark Roast Coffee";
    }
    
    public override double Cost()
    {
        return .99;
    }
}