namespace DecoratorPattern;

/// <summary>
/// 具体装饰器：光剑，攻击武器，战斗力 +20。
/// </summary>
public class Sword(Robot robot) : RobotDecorator(robot)
{
    public override string Description => _robot.Description + "，光剑";
    public override int Power() => _robot.Power() + 20;
}