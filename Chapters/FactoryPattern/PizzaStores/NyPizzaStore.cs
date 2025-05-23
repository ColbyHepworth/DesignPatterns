using DesignPatterns.FactoryPattern.IngredientFactory;
using DesignPatterns.FactoryPattern.IngredientFactory.Interfaces;
using DesignPatterns.FactoryPattern.Pizzas;
using DesignPatterns.FactoryPattern.Pizzas.Base;
using DesignPatterns.FactoryPattern.PizzaStores.Base;

namespace DesignPatterns.FactoryPattern.PizzaStores;

public class NyPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string item)
    {
        Pizza pizza;
        IPizzaIngredientFactory ingredientFactory = new NyPizzaIngredientFactory();

        switch (item)
        {
            case "cheese":
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("New York Style Cheese Pizza");
                break;
            case "veggie":
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("New York Style Veggie Pizza");
                break;
            case "clam":
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("New York Style Clam Pizza");
                break;
            case "pepperoni":
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.SetName("New York Style Pepperoni Pizza");
                break;
            default:
                throw new Exception("Unknown pizza type");
        }
        
        return pizza;
    }
}