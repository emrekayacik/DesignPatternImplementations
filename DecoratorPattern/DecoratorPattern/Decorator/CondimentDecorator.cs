using DecoratorPattern.Abstract;

namespace DecoratorPattern.Decorator;
abstract class CondimentDecorator : Beverage
{
    protected Beverage beverage;
    public CondimentDecorator(Beverage _beverage)
    {
        this.beverage = _beverage;
    }
}
