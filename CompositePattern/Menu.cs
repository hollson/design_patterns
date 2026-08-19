namespace CompositePattern;

/// <summary>
/// 菜单类，组合模式中的组合节点，可包含子菜单和菜单项。
/// </summary>
public class Menu(string name, string description) : MenuComponent
{
    private readonly List<MenuComponent> _components = [];

    public override string Name { get; } = name;

    public override string Description { get; } = description;

    public override void Add(MenuComponent component) => _components.Add(component);

    public override void Remove(MenuComponent component) => _components.Remove(component);

    public override MenuComponent GetChild(int i) => _components[i];

    public override void Print()
    {
        Console.WriteLine(Name);
        Console.WriteLine("___________");
        foreach (var menuComponent in _components)
        {
            menuComponent.Print();
        }
        Console.WriteLine();
    }
}
