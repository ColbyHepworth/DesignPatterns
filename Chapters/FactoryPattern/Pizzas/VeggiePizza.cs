using DesignPatterns.FactoryPattern.IngredientFactory.Interfaces;
using DesignPatterns.FactoryPattern.Pizzas.Base;

namespace DesignPatterns.FactoryPattern.Pizzas;

public class VeggiePizza(IPizzaIngredientFactory ingredientFactory) : Pizza
{
    private IPizzaIngredientFactory IngredientFactory { get; } = ingredientFactory;
    
    public override void Prepare()
    {
        Console.WriteLine("Preparing " + Name);
        Dough = IngredientFactory.CreateDough();
        Sauce = IngredientFactory.CreateSauce();
        Veggies = IngredientFactory.CreateVeggies();
    }
}