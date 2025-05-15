using System.Diagnostics.CodeAnalysis;
using DesignPatterns.ChapterOne.SimUDuck.Ducks.Behaviors.FlyBehaviors;
using DesignPatterns.ChapterOne.SimUDuck.Ducks.Behaviors.QuackBehaviors;

namespace DesignPatterns.ChapterOne.SimUDuck.Ducks;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        QuackBehavior = new NormalQuack();
        FlyBehavior = new FlyWithWings();
    }
    public override void Display()
    {
        Console.WriteLine("I'm a real Mallard duck");
    }
    
}