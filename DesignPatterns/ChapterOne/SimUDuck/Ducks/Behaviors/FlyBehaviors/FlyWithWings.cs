namespace DesignPatterns.ChapterOne.SimUDuck.Ducks.Behaviors.FlyBehaviors;

public class FlyWithWings : Interfaces.IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("Flying with wings");
    }
}