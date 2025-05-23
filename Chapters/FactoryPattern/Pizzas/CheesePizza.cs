using System.Diagnostics.CodeAnalysis;
using DesignPatterns.FactoryPattern.IngredientFactory.Interfaces;
using DesignPatterns.FactoryPattern.Pizzas.Base;

namespace DesignPatterns.FactoryPattern.Pizzas;

public class CheesePizza(IPizzaIngredientFactory ingredientFactory) : Pizza
{
    private IPizzaIngredientFactory IngredientFactory { get; } = ingredientFactory;
    
    public override void Prepare()
    {
        Console.WriteLine("Preparing " + Name);
        Dough = IngredientFactory.CreateDough();
        Sauce = IngredientFactory.CreateSauce();
        Cheese = IngredientFactory.CreateCheese();
    }

    public override void Cut()
    {
        Console.WriteLine("Cutting the pizza into square slices");
    }
}