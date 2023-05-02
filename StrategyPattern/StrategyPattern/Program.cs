using StrategyPattern.Concrete;
using StrategyPattern.Abstract;
using StrategyPattern.Strategies.Concrete.QuackBehavior;
using StrategyPattern.Strategies.Concrete.FlyBehavior;

Duck mallardDuck = new MallardDuck();
mallardDuck.Display();
mallardDuck.PerformQuack();
mallardDuck.PerformFly();
mallardDuck.SetQuackBehavior(new NoQuack());
mallardDuck.PerformQuack();

Console.WriteLine("\n");

Duck decoyDuck = new DecoyDuck();
decoyDuck.Display();
decoyDuck.PerformQuack();
decoyDuck.PerformFly();

Console.WriteLine("\n");

Duck normalDuck = new NormalDuck();
normalDuck.Display();
normalDuck.PerformQuack();
normalDuck.PerformFly();
normalDuck.SetFlyBehavior(new NoFly());
normalDuck.PerformFly();

Console.ReadKey();