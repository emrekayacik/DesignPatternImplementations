using DecoratorPattern.Abstract;

namespace DecoratorPattern.Concrete;

internal class Espresso : Beverage
{
    public override double GetCost()
    {
        return 1.99; //base espresso cost
    }

    public override string GetDesc()
    {
        return "Espresso";
    }
}
