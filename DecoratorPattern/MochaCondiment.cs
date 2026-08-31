namespace DecoratorPattern;

class MochaCondiment(Beverage beverage) : CondimentDecorator
{
    private readonly Beverage _beverage = beverage;

    public override string Description =>
        _beverage.Description.StartsWith("Mocha")
            ? "Double " + _beverage.Description
            : "Mocha " + _beverage.Description;

    public override double Cost() => 0.2 + _beverage.Cost();
}
