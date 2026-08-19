namespace DecoratorPattern;

class MochaCondiment(Beverage beverage) : CondimentDecorator
{
    private readonly Beverage _beverage = beverage;

    public override string Description
    {
        get
        {
            if (_beverage.Description.StartsWith("Mocha"))
            {
                return "Double " + _beverage.Description;
            }
            else
                return "Mocha " + _beverage.Description;
        }
    }

    public override double Cost() => 0.2 + _beverage.Cost();
}
