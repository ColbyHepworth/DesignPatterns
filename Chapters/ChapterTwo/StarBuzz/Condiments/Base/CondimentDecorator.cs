using DesignPatterns.ChapterTwo.StarBuzz.Beverages.Base;

namespace DesignPatterns.ChapterTwo.StarBuzz.Condiments.Base;

public abstract class CondimentDecorator : Beverage
{
    protected Beverage DecoratedBeverage;
    public abstract override string GetDescription();
    
}