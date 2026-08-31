namespace CompositePattern;

/// <summary>
/// 菜单组件基类，定义菜单和菜单项的统一接口。
/// </summary>
public class MenuComponent
{
    public virtual void Add(MenuComponent component) => throw new NotImplementedException();
    public virtual void Remove(MenuComponent component) => throw new NotImplementedException();
    public virtual MenuComponent GetChild(int i) => throw new NotImplementedException();

    public virtual string Name { get; } = string.Empty;
    public virtual string Description { get; } = string.Empty;
    public virtual bool Vegetarian { get; }
    public virtual double Price { get; }

    public virtual void Print() => throw new NotImplementedException();
}
