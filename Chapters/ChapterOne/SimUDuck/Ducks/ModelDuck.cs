using DesignPatterns.ChapterOne.SimUDuck.Ducks.Behaviors.FlyBehaviors;
using DesignPatterns.ChapterOne.SimUDuck.Ducks.Behaviors.QuackBehaviors;

namespace DesignPatterns.ChapterOne.SimUDuck.Ducks;

public class ModelDuck : Duck
{
    public ModelDuck()
    {
        FlyBehavior = new FlyNoWay();
        QuackBehavior = new NormalQuack();
    }
    
    public override void Display()
    {
        Console.WriteLine("I'm a model duck");
    }
}