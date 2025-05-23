using DesignPatterns.FactoryPattern.Pizzas;
using DesignPatterns.FactoryPattern.Pizzas.Base;
using DesignPatterns.FactoryPattern.PizzaStores;
using DesignPatterns.FactoryPattern.PizzaStores.Base;

namespace DesignPatterns.FactoryPattern;

public class PizzaTestDrive
{
    public void Run()
    {
        PizzaStore nyStore = new NyPizzaStore();
        PizzaStore chicagoStore = new ChicagoPizzaStore();

        Pizza pizza = nyStore.OrderPizza("cheese");
        Console.WriteLine(pizza.GetName());
        
        pizza = chicagoStore.OrderPizza("cheese");
        Console.WriteLine(pizza.GetName());
        
        
    }
}