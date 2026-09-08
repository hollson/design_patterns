namespace DecoratorPattern;

/// <summary>
/// 具体装饰器：护甲，抵御伤害，战斗力 +10。
/// </summary>
public class Armor(Robot robot) : RobotDecorator(robot)
{
    public override string Description => _robot.Description + "，护甲";
    public override int Power() => _robot.Power() + 10;
}