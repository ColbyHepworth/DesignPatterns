using DesignPatterns.ChapterOne.SimUDuck.Ducks;
using DesignPatterns.ChapterOne.SimUDuck.Ducks.Behaviors.FlyBehaviors;

namespace DesignPatterns.ChapterOne.SimUDuck;

public class MiniDucksSimulator
{
    public void Run()
    {
        Duck mallard = new MallardDuck();
        mallard.PerformQuack();
        mallard.PerformFly();
        
        Duck model = new ModelDuck();
        model.PerformFly();
        model.SetFlyBehavior(new FlyRocketPowered());
        model.PerformFly();
    }
}