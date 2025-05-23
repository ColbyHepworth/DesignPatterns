using DesignPatterns.FactoryPattern.IngredientFactory;
using DesignPatterns.FactoryPattern.IngredientFactory.Interfaces;
using DesignPatterns.FactoryPattern.Pizzas;
using DesignPatterns.FactoryPattern.Pizzas.Base;
using DesignPatterns.FactoryPattern.PizzaStores.Base;

namespace DesignPatterns.FactoryPattern.PizzaStores;

public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        IPizzaIngredientFactory pizzaIngredientFactory = new ChicagoPizzaIngredientFactory();
        Pizza pizza;

        switch (type)
        {
            case "cheese":
                pizza = new CheesePizza(pizzaIngredientFactory);
                pizza.SetName("Chicago Style Cheese Pizza");
                break;
            case "veggie":
                pizza = new VeggiePizza(pizzaIngredientFactory);
                pizza.SetName("Chicago Style Veggie Pizza");
                break;
            case "clam":
                pizza = new ClamPizza(pizzaIngredientFactory);
                pizza.SetName("Chicago Style Clam Pizza");
                break;
            case "pepperoni":
                pizza = new PepperoniPizza(pizzaIngredientFactory);
                pizza.SetName("Chicago Style Pepperoni Pizza");
                break;
            default:
                throw new Exception("Unknown pizza type");
        }
        return pizza;
    }
}