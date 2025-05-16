using DesignPatterns.ChapterTwo.StarBuzz.Beverages.Base;
using DesignPatterns.ChapterTwo.StarBuzz.Condiments.Base;

namespace DesignPatterns.ChapterTwo.StarBuzz.Condiments;

public class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage)
    {
        DecoratedBeverage = beverage;
    }
    
    public override string GetDescription()
    {
        return $"{DecoratedBeverage.GetDescription()}, Mocha";
    }

    public override double Cost()
    {
        var cost = DecoratedBeverage.Cost();
        switch (GetSize())
        {
            case Size.Tall:
                cost += .10;
                break;
            case Size.Grande:
                cost += .15;
                break;
            case Size.Venti:
                cost += .20;
                break;
        }
        return Math.Round(cost, 2);
    }
}