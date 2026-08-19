namespace DecoratorPattern;

class HouseBlend : Beverage
{
    public HouseBlend() => _description = "House Blend";

    public override string Description => _description;

    public override double Cost() => 2.49;
}
