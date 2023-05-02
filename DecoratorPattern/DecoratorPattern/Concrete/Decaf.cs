using DecoratorPattern.Abstract;

namespace DecoratorPattern.Concrete;
internal class Decaf : Beverage
{
    public override double GetCost()
    {
        return 2.99; // base decaf cost
    }

    public override string GetDesc()
    {
        return "Decaf";
    }
}
