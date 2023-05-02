using StrategyPattern.Abstract;
using StrategyPattern.Strategies.Concrete.FlyBehavior;
using StrategyPattern.Strategies.Concrete.QuackBehavior;

namespace StrategyPattern.Concrete;

internal class NormalDuck : Duck
{
    public NormalDuck()
    {
        quackBehavior = new QuackNormal();
        flyBehavior = new FlyWithWings();
    }
    public override void Display()
    {
        Console.WriteLine("I look like a normal duck!");
    }
}
