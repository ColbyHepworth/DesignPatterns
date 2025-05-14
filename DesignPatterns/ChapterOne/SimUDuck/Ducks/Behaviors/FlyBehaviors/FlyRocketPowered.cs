using DesignPatterns.ChapterOne.SimUDuck.Ducks.Behaviors.Interfaces;

namespace DesignPatterns.ChapterOne.SimUDuck.Ducks.Behaviors.FlyBehaviors;

public class FlyRocketPowered : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with a rocket!");
    }
}