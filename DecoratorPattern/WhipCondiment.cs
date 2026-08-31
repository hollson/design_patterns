namespace DecoratorPattern;

class WhipCondiment(Beverage beverage) : CondimentDecorator
{
    private readonly Beverage _beverage = beverage;

    public override string Description =>
        _beverage.Description.StartsWith("Whip")
            ? "Double " + _beverage.Description
            : "Whip " + _beverage.Description;

    public override double Cost() => 0.15 + _beverage.Cost();
}
