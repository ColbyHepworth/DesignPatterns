using DesignPatterns.FactoryPattern.Pizzas.Base;

namespace DesignPatterns.FactoryPattern.PizzaStores.Base;

public abstract class PizzaStore
{
    public Pizza OrderPizza(string type)
    {
        Pizza pizza = CreatePizza(type);
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        return pizza;
    }
    
    protected abstract Pizza CreatePizza(string type);
}