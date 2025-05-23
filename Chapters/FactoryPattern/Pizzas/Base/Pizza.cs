using DesignPatterns.FactoryPattern.Ingredients.Interface;

namespace DesignPatterns.FactoryPattern.Pizzas.Base;

public abstract class Pizza
{
    protected string Name = string.Empty;
    protected IDough Dough { get; set; }
    protected ISauce Sauce { get; set; }
    protected ICheese Cheese { get; set; }
    protected IPepperoni Pepperoni { get; set; }
    protected List<IVeggie> Veggies { get; set; } = new ();
    protected IClams Clams { get; set; }

    public abstract void Prepare();

    public virtual void Bake()
    {
        Console.WriteLine("Baking for 25 minutes at 350 degrees");
    }

    public virtual void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    public virtual void Box()
    {
        Console.WriteLine("Placing pizza in official PizzaStore box");
    }

    public string GetName()
    {
        return Name;
    }
    public void SetName(string name)
    {
        Name = name;
    }
    
}