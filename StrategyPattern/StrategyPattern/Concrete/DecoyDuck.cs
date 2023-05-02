using StrategyPattern.Abstract;
using StrategyPattern.Strategies.Concrete.FlyBehavior;
using StrategyPattern.Strategies.Concrete.QuackBehavior;

namespace StrategyPattern.Concrete;
internal class DecoyDuck : Duck
{
    public DecoyDuck()
    {
        flyBehavior = new NoFly();
        quackBehavior = new NoQuack();
    }
    public override void Display()
    {
        Console.WriteLine("I look like a decoy duck!");
    }
}
