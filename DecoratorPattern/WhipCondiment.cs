namespace DecoratorPattern;

class WhipCondiment(Beverage beverage) : CondimentDecorator
{
    private readonly Beverage _beverage = beverage;

    public override string Description
    {
        get
        {
            if (_beverage.Description.StartsWith("Whip"))
            {
                return "Double " + _beverage.Description;
            }
            else
                return "Whip " + _beverage.Description;
        }
    }

    public override double Cost() => 0.15 + _beverage.Cost();
}
