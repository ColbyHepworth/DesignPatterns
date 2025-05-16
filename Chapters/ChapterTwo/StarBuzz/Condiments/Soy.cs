using DesignPatterns.ChapterTwo.StarBuzz.Beverages.Base;
using DesignPatterns.ChapterTwo.StarBuzz.Condiments.Base;

namespace DesignPatterns.ChapterTwo.StarBuzz.Condiments;

public class Soy : CondimentDecorator
{
    public Soy(Beverage beverage)
    {
        DecoratedBeverage = beverage;
    }
    
    public override string GetDescription()
    {
        return $"{DecoratedBeverage.GetDescription()}, Soy";
    }

    public override double Cost()
    {
        var cost = DecoratedBeverage.Cost();
        switch (DecoratedBeverage.GetSize())
        {
            case Beverage.Size.Tall:
                cost += .10;
                break;
            case Beverage.Size.Grande:
                cost += .15;
                break;
            case Beverage.Size.Venti:
                cost += .20;
                break;
        }
        return Math.Round(cost, 2);
    }
}