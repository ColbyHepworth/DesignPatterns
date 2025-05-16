using DesignPatterns.ChapterTwo.StarBuzz.Beverages.Base;
using DesignPatterns.ChapterTwo.StarBuzz.Condiments.Base;

namespace DesignPatterns.ChapterTwo.StarBuzz.Condiments;

public class SteamedMilk : CondimentDecorator
{
    public SteamedMilk(Beverage beverage)
    {
        DecoratedBeverage = beverage;
    }
    
    public override string GetDescription()
    {
        return DecoratedBeverage.GetDescription() + ", Steamed Milk";
    }
    
    public override double Cost()
    {
        var cost = DecoratedBeverage.Cost();
        switch (DecoratedBeverage.GetSize())
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