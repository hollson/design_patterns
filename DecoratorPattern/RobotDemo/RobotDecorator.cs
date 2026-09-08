namespace DecoratorPattern;

/// <summary>
/// 抽象装饰器：继承抽象组件保持类型一致，持有被装饰对象（机器人）引用。
/// </summary>
public abstract class RobotDecorator(Robot robot) : Robot
{
    protected readonly Robot _robot = robot;
}