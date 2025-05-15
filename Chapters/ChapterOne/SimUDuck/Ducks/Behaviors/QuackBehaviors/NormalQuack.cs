
namespace DesignPatterns.ChapterOne.SimUDuck.Ducks.Behaviors.QuackBehaviors;

public class NormalQuack : Interfaces.IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Quack");    
    }
}