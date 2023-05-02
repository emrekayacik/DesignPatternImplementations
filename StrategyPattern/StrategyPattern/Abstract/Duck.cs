using StrategyPattern.Strategies;

namespace StrategyPattern.Abstract;
public abstract class Duck
{
    protected IFlyBehavior flyBehavior;
    protected IQuackBehavior quackBehavior;

    public void SetQuackBehavior(IQuackBehavior _quackBehavior)
    {
        quackBehavior = _quackBehavior;
    }
    public void SetFlyBehavior(IFlyBehavior _flyBehavior)
    {
        flyBehavior = _flyBehavior;
    }

    public void PerformQuack()
    {
        quackBehavior.Quack();
    }
    public void PerformFly()
    {
        flyBehavior.Fly();
    }
    public abstract void Display();
    public void Swim()
    {
        Console.WriteLine("Swimming as usual...");
    }
}
