using DesignPatterns.ChapterOne.SimUDuck.Ducks.Behaviors.Interfaces;

namespace DesignPatterns.ChapterOne.SimUDuck.Ducks;

public abstract class Duck
{
    protected IFlyBehavior FlyBehavior;
    protected IQuackBehavior QuackBehavior;
    
    public abstract void Display();

    public void PerformFly()
    {
        FlyBehavior.Fly();
    }
    
    public void PerformQuack()
    {
        QuackBehavior.Quack();
    }
    
    public void Swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }

    public void SetFlyBehavior(IFlyBehavior flyBehavior)
    {
        FlyBehavior = flyBehavior;
    }

    public void SetQuackBehavior(IQuackBehavior quackBehavior)
    {
        QuackBehavior = quackBehavior;
    }
}