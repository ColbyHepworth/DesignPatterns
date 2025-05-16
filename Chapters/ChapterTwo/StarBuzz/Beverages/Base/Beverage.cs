namespace DesignPatterns.ChapterTwo.StarBuzz.Beverages.Base;

public abstract class Beverage
{
    protected string Description { get; set; } = "Unknown Beverage";
    public enum Size
    {
        Tall,
        Grande,
        Venti
    }

    protected Size BeverageSize { get; set; } = Size.Tall;
    public virtual string GetDescription()
    {
        return $"({BeverageSize}) {Description}";
    }
    public abstract double Cost();
    
    public void SetSize(Size size)
    {
        BeverageSize = size;
    }
    
    public Size GetSize()
    {
        return BeverageSize;
    }
}