namespace DesignPatterns.ChapterOne.SimUDuck.Ducks.Behaviors.FlyBehaviors;

public class FlyNoWay : Interfaces.IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I can't fly");
    }
}