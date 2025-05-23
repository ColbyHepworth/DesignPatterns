using DesignPatterns.FactoryPattern.Ingredients.Interface;

namespace DesignPatterns.FactoryPattern.IngredientFactory.Interfaces;

public interface IPizzaIngredientFactory
{
    public IDough CreateDough();
    public ISauce CreateSauce();
    public ICheese CreateCheese();
    public List<IVeggie> CreateVeggies();
    public IPepperoni CreatePepperoni();
    public IClams CreateClams();
}