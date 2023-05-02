using DecoratorPattern.Abstract;

namespace DecoratorPattern.Decorator.Condiments;

internal class Milk : CondimentDecorator
{
    double milkCost = 2.99;
    string milkDesc = ", Milk";
    public Milk(Beverage beverage) : base(beverage)
    {
        
    }
    public override double GetCost()
    {
        return beverage.GetCost() + milkCost;
    }

    public override string GetDesc()
    {
        return beverage.GetDesc() + milkDesc;
    }
}
