using DesignPatterns.ChapterTwo.StarBuzz.Beverages.Base;

namespace DesignPatterns.ChapterTwo.StarBuzz.Beverages;

public class HouseBlend : Beverage
{
    public HouseBlend()
    {
        Description = "House Blend Coffee";
    }
    
    public override double Cost()
    {
        return .89;
    }
}