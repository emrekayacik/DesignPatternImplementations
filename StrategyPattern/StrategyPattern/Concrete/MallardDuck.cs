using StrategyPattern.Abstract;
using StrategyPattern.Strategies.Concrete.FlyBehavior;
using StrategyPattern.Strategies.Concrete.QuackBehavior;

namespace StrategyPattern.Concrete;
internal class MallardDuck : Duck
{
    public MallardDuck()
    {
        flyBehavior = new FlyWithWings();
        quackBehavior = new Squack();
    }

    public override void Display()
    {
        Console.WriteLine("I look like a mallard duck");
    }
}
