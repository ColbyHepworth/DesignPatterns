namespace DesignPatterns.ChapterOne.SimUDuck.Ducks.Behaviors.QuackBehaviors;

public class MuteQuack : Interfaces.IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("<< Silence >>");
    }
}