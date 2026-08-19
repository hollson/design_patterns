namespace DecoratorPattern;

/// <summary>
/// 饮品抽象基类，定义饮品的描述和价格接口。
/// </summary>
abstract class Beverage
{
    protected string _description = "No Description";
    public abstract string Description { get; }
    public abstract double Cost();
}
