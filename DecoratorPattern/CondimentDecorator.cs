namespace DecoratorPattern;

/// <summary>
/// 调料装饰器抽象基类，所有具体调料装饰器的父类。
/// </summary>
abstract class CondimentDecorator : Beverage
{
    public abstract override string Description { get; }
}
