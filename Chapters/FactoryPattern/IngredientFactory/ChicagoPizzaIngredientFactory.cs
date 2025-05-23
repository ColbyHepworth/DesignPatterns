using DesignPatterns.FactoryPattern.IngredientFactory.Interfaces;
using DesignPatterns.FactoryPattern.Ingredients.Cheese;
using DesignPatterns.FactoryPattern.Ingredients.Clams;
using DesignPatterns.FactoryPattern.Ingredients.Dough;
using DesignPatterns.FactoryPattern.Ingredients.Interface;
using DesignPatterns.FactoryPattern.Ingredients.Pepperoni;
using DesignPatterns.FactoryPattern.Ingredients.Sauce;
using DesignPatterns.FactoryPattern.Ingredients.Veggies;

namespace DesignPatterns.FactoryPattern.IngredientFactory;

public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    
{
    public IDough CreateDough()
    {
        return new ThickCrustDough();
    }

    public ISauce CreateSauce()
    {
        return new PlumTomatoSauce();
    }

    public ICheese CreateCheese()
    {
        return new ReggianoCheese();
    }

    public List<IVeggie> CreateVeggies()
    {
        var veggies = new List<IVeggie>
        {
            new Garlic(),
            new Onion(),
            new Mushroom(),
            new RedPepper()
        };
        return veggies;
    }

    public IPepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public IClams CreateClams()
    {
        return new FrozenClams();
    }
}