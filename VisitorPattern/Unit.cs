namespace VisitorPattern;

/// <summary>
/// 单元抽象基类 —— 组合模式中的容器/叶子基类。
/// Accept() 遍历子单元并递归调用 Accept，形成对整棵组合树的遍历。
/// </summary>
public abstract class Unit
{
    private readonly Unit[] _units;

    public Unit(params Unit[] units)
    {
        _units = units;
    }

    public virtual void Accept(IUnitVisitor visitor)
    {
        foreach (var unit in _units)
        {
            unit.Accept(visitor);
        }
    }

    public abstract override  string ToString();
}
