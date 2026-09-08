namespace DecoratorPattern;

/// <summary>
/// 具体装饰器：头盔，提升防御，战斗力 +5。
/// </summary>
public class Helmet(Robot robot) : RobotDecorator(robot)
{
    public override string Description => _robot.Description + "，头盔";
    public override int Power() => _robot.Power() + 5;
}