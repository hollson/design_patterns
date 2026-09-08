namespace DecoratorPattern;

/// <summary>
/// 抽象组件：机器人，定义描述与战斗力的公共契约。
/// </summary>
public abstract class Robot
{
    public abstract string Description { get; }
    public abstract int Power();
}