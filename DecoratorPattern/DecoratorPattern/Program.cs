using DecoratorPattern.Abstract;
using DecoratorPattern.Concrete;
using DecoratorPattern.Decorator.Condiments;

Beverage milkyEspressoWithCaramel = new Milk(
    new Caramel(
        new Espresso()
        )
    );

Beverage decafWithBrownShot = new BrownShot(new Decaf());

Console.WriteLine("Your coffee: {0}\nCost: {1}",
    milkyEspressoWithCaramel.GetDesc(),
    milkyEspressoWithCaramel.GetCost());

Console.WriteLine("\n\n");

Console.WriteLine("Your coffee: {0}\nCost: {1}",
    decafWithBrownShot.GetDesc(),
    decafWithBrownShot.GetCost());
