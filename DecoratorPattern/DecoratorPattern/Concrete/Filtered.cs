using DecoratorPattern.Abstract;

namespace DecoratorPattern.Concrete;
internal class Filtered : Beverage
{
    public override double GetCost()
    {
        return 4.99; // base filtered coffee cost
    }

    public override string GetDesc()
    {
        return "Filtered";
    }
}
