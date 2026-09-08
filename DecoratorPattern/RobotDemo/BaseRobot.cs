namespace DecoratorPattern;

/// <summary>
/// 具体组件：基础机器人，无任何装备。
/// </summary>
public class BaseRobot : Robot
{
    public override string Description => "基础机器人";
    public override int Power() => 10;
}