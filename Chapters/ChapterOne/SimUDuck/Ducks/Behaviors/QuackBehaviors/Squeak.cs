namespace DesignPatterns.ChapterOne.SimUDuck.Ducks.Behaviors.QuackBehaviors;

public class Squeak : Interfaces.IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Squeak");
    }
}