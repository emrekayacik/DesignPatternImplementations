using DecoratorPattern.Abstract;

namespace DecoratorPattern.Decorator.Condiments;
internal class Caramel : CondimentDecorator
{
    double caramelCost = 0.99;
    string caramelDesc = ", Caramel";
    public Caramel(Beverage beverage) : base(beverage)
    {
        
    }
    public override double GetCost()
    {
        return beverage.GetCost() + caramelCost;
    }

    public override string GetDesc()
    {
        return beverage.GetDesc() + caramelDesc;
    }
}
