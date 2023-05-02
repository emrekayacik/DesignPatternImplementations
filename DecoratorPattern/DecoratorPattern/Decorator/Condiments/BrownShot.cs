using DecoratorPattern.Abstract;

namespace DecoratorPattern.Decorator.Condiments;
internal class BrownShot : CondimentDecorator
{
    double brownShowCost = 1.99;
    string brownShowDesc = ", Brown Shot";

    public BrownShot(Beverage beverage) : base(beverage)
    {
        
    }

    public override double GetCost()
    {
        return beverage.GetCost() + brownShowCost;
    }

    public override string GetDesc()
    {
        return beverage.GetDesc() + brownShowDesc;
    }
}
